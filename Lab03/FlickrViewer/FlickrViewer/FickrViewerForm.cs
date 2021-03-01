﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FlickrViewer
{
   public partial class FickrViewerForm : Form
   {
        private int counter = 0;
        // Use your Flickr API key here--you can get one at:
        // https://www.flickr.com/services/apps/create/apply
        private const string KEY = "fb985c089b4cb15e2b181b4d89080a09";
        //secret: 8b8bdaffbb7a76c5
        // object used to invoke Flickr web service      
        private static HttpClient flickrClient = new HttpClient();

      Task<string> flickrTask = null; // Task<string> that queries Flickr

      public FickrViewerForm()
      {
         InitializeComponent();
      }

      // initiate asynchronous Flickr search query; 
      // display results when query completes
      private async void searchButton_Click(object sender, EventArgs e)
      {/*
            //if flickrTask already running, prompt user
         if (flickrTask?.Status != TaskStatus.RanToCompletion)
            {
                var result = MessageBox.Show(
                   "Cancel the current Flickr search?",
                   "Are you sure?", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

            //determine whether user wants to cancel prior search
            if (result == DialogResult.No)
                {
                    return;
                }
                else
                {

                    flickrClient.CancelPendingRequests(); // cancel search
                }
            }
*/
            // Flickr's API URL for searches                         
            var flickrURL = "https://api.flickr.com/services/rest/?method=" +
            $"flickr.photos.search&api_key={KEY}&" +
            $"tags={inputTextBox.Text.Replace(" ", ",")}" +
            "&tag_mode=all&per_page=500&privacy_filter=1";

         imagesListBox.DataSource = null; // remove prior data source
         imagesListBox.Items.Clear(); // clear imagesListBox
         pictureBox.Image = null; // clear pictureBox
         imagesListBox.Items.Add("Loading..."); // display Loading...

         // invoke Flickr web service to search Flick with user's tags
         flickrTask = flickrClient.GetStringAsync(flickrURL);

         // await flickrTask then parse results with XDocument and LINQ
         XDocument flickrXML = XDocument.Parse(await flickrTask);

         // gather information on all photos
         var flickrPhotos =
            from photo in flickrXML.Descendants("photo")
            let id = photo.Attribute("id").Value
            let title = photo.Attribute("title").Value
            let secret = photo.Attribute("secret").Value
            let server = photo.Attribute("server").Value
            let farm = photo.Attribute("farm").Value
            select new FlickrResult
            {
               Title = title,
               URL = $"https://farm{farm}.staticflickr.com/" +
                  $"{server}/{id}_{secret}.jpg"
            };
         imagesListBox.Items.Clear(); // clear imagesListBox

         // set ListBox properties only if results were found
         if (flickrPhotos.Any())
         {
            imagesListBox.DataSource = flickrPhotos.ToList();
            imagesListBox.DisplayMember = "Title";
         }
         else // no matches were found
         {
            imagesListBox.Items.Add("No matches");
         }
      }

      // display selected image
      private async void imagesListBox_SelectedIndexChanged(
         object sender, EventArgs e)
      {
            //Instanciate Image objects to use in parallel process
            string path = $"../../../../{counter}.jpeg";
            if (imagesListBox.SelectedItem != null)
         {
                Image imageToDisplayInImageBox;
                Image imageToSave;
                Image imageForThumnail;

                string selectedURL = ((FlickrResult) imagesListBox.SelectedItem).URL;

            // use HttpClient to get selected image's bytes asynchronously
            byte[] imageBytes = await flickrClient.GetByteArrayAsync(selectedURL);

            // display downloaded image in pictureBox                  
            using (var memoryStream = new MemoryStream(imageBytes))
            {
                    imageToDisplayInImageBox = Image.FromStream(memoryStream);
                    imageToSave = Image.FromStream(memoryStream);
                    imageForThumnail = Image.FromStream(memoryStream);
            }

            Parallel.Invoke(
                () =>
                {
                    //Sets the retrieved image to the image box container
                    pictureBox.Image = imageToDisplayInImageBox;
                },
                () =>
                {

                    //Saves image to "FlcikrViewer" Folder
                    var iBit = new Bitmap(imageToSave);
                    iBit.Save(path, ImageFormat.Jpeg);

                },
                () =>
                {
                    int thumbWidth = imageForThumnail.Width;
                    int thumbHeight = imageForThumnail.Height;
                    // create and save thumbnail to "FlcikrViewer/bin/Debug/net5.0-windows" folder
                    var thumbnail = imageForThumnail.GetThumbnailImage(thumbWidth / 10, thumbHeight / 10, null, IntPtr.Zero);

                    using (var thumbnailStream = new MemoryStream())
                    {
                        thumbnail.Save(thumbnailStream, ImageFormat.Jpeg);
                        File.WriteAllBytes($"{counter}thumb.jpeg", thumbnailStream.ToArray());
                    }

                });
               counter++;
         }
      }
    }
}

/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************/

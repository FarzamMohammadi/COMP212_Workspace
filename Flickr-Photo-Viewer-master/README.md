# Flickr-Photo-Viewer
This project is Lab Assignment under course Software Development with Frameworks, Computer Science, California State University - Long Beach, May 2018. In this project we have created Flickr Viewer app that allows users to search for photos on the photo-sharing website Flickr, then browse through the result. The app uses an asynchronous method to invoke a Flickr web service. The Flickr Viewer app allows user to search by tag for photos that users worldwide have uploaded to Flickr. To access the Flickr web service on your computer, we have obtained our own Flickr API key from
http://www.flickr.com/services/apps/create/apply
In this program, we specify values for the following parameters:
•    api_key (Required)
•    tags
A comma-delimited list of tags. Photos with one or more of the tags listed will be returned. You can exclude results that match a term by prepending it with a - character.
•    tag_mode
Either 'any' for an OR combination of tags, or 'all' for an AND combination. Defaults to 'any' if not specified.
•    per_page
Number of photos to return per page. If this argument is omitted, it defaults to 100. The maximum allowed value is 500.
•    privacy_filter (Optional)
Return photos only matching a certain privacy level. This only applies when making an authenticated call to view photos you own. Use value 1.
The method flickr.photos.search returns the standard photo list xml:
<photos page="2" pages="89" perpage="10" total="881">
<photo id="2636" owner="47058503995@N01" 
secret="a123456" server="2" title="test_04"
ispublic="1" isfriend="0" isfamily="0" />
<photo id="2635" owner="47058503995@N01"
secret="b123456" server="2" title="test_03"
ispublic="0" isfriend="1" isfamily="1" />
<photo id="2633" owner="47058503995@N01"
secret="c123456" server="2" title="test_01"
ispublic="1" isfriend="0" isfamily="0" />
<photo id="2610" owner="12037949754@N01"
secret="d123456" server="2" title="00_tall"
ispublic="1" isfriend="0" isfamily="0" />
</photos>
REST Request Format
REST is the simplest request format to use - it's a simple HTTP GET or POST action.
The REST Endpoint URL is https://api.flickr.com/services/rest/
To request the flickr.test.echo service, invoke like this:
https://api.flickr.com/services/rest/?method=flickr.test.echo&name=value



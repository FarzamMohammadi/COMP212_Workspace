   M S B A M L   `   `   `  ����V  R301109706(Mohammadi)_Test01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:_301109706_Mohammadi__Test01_301109706_Mohammadi__Test01  5   	   -    '_301109706_Mohammadi__Test01.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:_301109706_Mohammadi__Test01     5   	     � Title$  COMP212 - Midterm��5   	   
�������$	��530��65   $	��816��6B   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ CovidDataGrid��5
      $
��Left=�6*   $	��Top=�6L   $	��499��6d   $��	0,0,246,0q�6q      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Country/Region��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *countryRegion+6_     5      $ Province/State��6%   $	 120 6_    6=   �� *provinceState+6_     5      $ Number of Recovered��6%   $	 180 6h    6B   �� *numberOfRecovered+6h     5      $ Record Date��6%   $ * 6y    6:   �� *recordDates+ �� StringFormat$ {0:MM/dd/yyyy}��6y   5      �� 5   
   $
��Left=�6   $��
608,74,0,0q�6+   $	��Top=�6?   �� 5   
   $��Country/Region:��6   $
��Left=�6*   $��
570,25,0,0q�6E   $	��Top=�6Y    J� RenderTransformOrigin$ -0.079,2.077&�6q   �� 5   
   $��Province/State:��6   $
��Left=�6*   $��
570,59,0,0q�6E   $	��Top=�6Y   $ -0.079,2.077&�6q   �� 5   
   $��Date:��6   $
��Left=�6    $��
570,92,0,0q�6;   $	��Top=�6O   $ -0.079,2.077&�6g   �� 5   
   $��Recovered#:��6   $
��Left=�6&   $��570,118,0,0q�6A   $	��Top=�6V   $ -0.079,2.077&�6n   �� 5   
   -   5         ��Name$ countryRegionDropDown��5      $
��Left=�62   $��
678,29,0,0q�6M   $	��Top=�6a   $	��120��6y   6�   �� 5   
   -   5        	 ��Name$	 provinceTxt��5      $
��Left=�6'   $��23��6B   $��
678,61,0,0q�6N   
 �� TextWrapping$

 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   �� 5   
   -   5        $	 numberOfRecovered��5      $
��Left=�6-   $��23��6H   $��678,122,0,0q�6T   $

 Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��120��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ newRecordDate��5      $
��Left=�6,   $��
678,93,0,0q�6G   $	��Top=�6[   $��21��6s   $	��120��6   $ -0.483,-0.27&�6�   �� 5   
   -   5         ��Name$ insertButton��5      $��INSERT��6'   $
��Left=�68   $��626,173,0,0q�6S   $	��Top=�6h   $	��104��6�   $��41��6�   6�   5       5!      
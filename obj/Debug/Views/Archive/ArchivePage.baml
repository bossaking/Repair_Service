   M S B A M L   `   `   `  ����I  ERepair_Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Repair_ServiceRepair_Service  5           Repair_Service.ArchivePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Repair_Service     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        N� 
Background
  ����� N� FontSize$ 16(�5      .��5      �  � ShowGridLines .   � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��Center=�5      $��Center=�5      $��30(�5      .��6   	ARCHIVE5      �� 5   
   -   5        $��0��5      $
��10,0q�5       $
��Left=�5!      $��Center=�5"      
���   � �� IsCancel .    MaterialDesignIconButton#��[  5&       � ToolTip$
 Back��5'      .��5(      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�6&   5)      &   System.Windows.Controls.DataGrid  5-   
   -   5        $��DataGrid��5.      $��1��5/      $
��auto��50      $��5,5,5,5q�51      $��Center=�52      $	��Top=�53         AutoGenerateColumns .     CanUserResizeColumns .  	   CanUserResizeRows	 .  
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$

 auto 57      $��16(�58         
IsReadOnly .    Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6B   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
Id_Order+6B     5<      $ Client name��6E    6%   �� *Client.Name+6E     5=      $ Client phone number��6M    6%   �� *Client.Phone_Number+6M     5>      $ Device name��6L    6%   �� *Device.Model_Title+6L     5?      $ Device type��6W    6%   �� *Device.Device_Type.Type_Title+6W     5@      $ 
Order date��6D    6%   �� *
Order_Date+6D     5A      $ Status��6F    6%   �� *Status.Title+6F   4  .System.Windows.Controls.DataGridTemplateColumn  5B      $ Action��6)      CellTemplate 5C      �� 5D      .R�5E      � .+�5F   "   �� -   5        $��0,0,15,0q�5G   %   $��0q�5H   %   
���   �  MaterialDesignFlatButton#��[ 5K   %   $ Details��5L   %   .��5M   &     $��22��5N   )   $��22��5O   )   $ TextBoxSearchOutline=�5P   )   5Q   #   �� 5R   "   -   5        $��0,0,15,0q�5S   %   $��0q�5T   %   
���   �#��[ 5W   %   $ Restore��5X   %   .��5Y   &     $��22��5Z   )   $��22��5[   )   $ Restore=�5\   )   5]   #   �� 5^   "   -   5        $��0q�5_   %   
���   �#��[ 5b   %   $ Delete��5c   %   .��5d   &     $��22��5e   )   $��22��5f   )   $ Delete=�5g   )   5h   #   5i      5j      5l      5n      5p      5r      
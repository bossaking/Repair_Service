   M S B A M L   `   `   `  ����I  ERepair_Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Repair_ServiceRepair_Service  5          Repair_Service.MainPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Repair_Service     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      -   5          N� 
Background
  ����� N� FontSize$ 16(�5      .��5      �  � ShowGridLines .   � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   � $��0��6    .   � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��auto �6#   �� 5      $��* �6#   .+�5      �� -   5        $��2��5       $
��10,0q�5!      $��Right=�5"      
���   � �� IsCancel .    MaterialDesignIconButton#��[  5&       � ToolTip$ Logout��5'      .��5(      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Logout=�6*   5)      � 5*      $��1��5+      $��Center=�5,      $��Center=�5-      .+�5.      �� -   5        $��5q�5.      .��6@   	Clients6I   �� 5/      -   5        $��5q�5/      .��6@   	Devices6I   �� 50      -   5        $��5q�50      .��6>   Types6E   �� 51      -   5        $��5q�51      .��6?   Brands6G   �� 52      -   5        $��5q�52      .��6A   
Problems6K   � 53      -   5        $��AdministratorPanel��53      $y�	Collapsed=�66   .+�54      �� -	   5        $��5q�54      .��6F   	Employees6Q   �� 55      -
   5        $��5q�55      .��6B   Roles6I   �� 56      -   5        $��5q�56      .��6C   Salons6K   �� 57      -   5        $��5q�57      .��6E   
Statuses6O   �� 58      -   5        $��5q�58      .��6D   	Archive6M   59      5:      5<      � 5?   
   $��1��5@      $��Center=�5A      $��Center=�5B      .+�5C        $��25��5D      $��25��5E      $��0,0,2,0q�5F      $��Bottom=�5G      $ Search=�5H      �� 5I      -   5        $��TextBoxSearch��5J      $	��200��5K      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Search��5L      .  (MaterialDesignThemes.Wpf.TextFieldAssist	   HasClearButton	 .  % !MaterialDesignFloatingHintTextBox#��[ 5N      5O      5P      &   System.Windows.Controls.DataGrid  5T   
   -   5        $��DataGrid��5U      $��2��5V      $
��auto��5W      $��5,5,5,5q�5X      $��Center=�5Y      $	��Top=�5Z      
   AutoGenerateColumns
 .     CanUserResizeColumns .     CanUserResizeRows .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 auto 5^      $��16(�5_         
IsReadOnly .    Columns 5a      0  *System.Windows.Controls.DataGridTextColumn  5b      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6B   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
Id_Order+6B     5c      $ Client name��6E    6%   �� *Client.Name+6E     5d      $ Client phone number��6M    6%   �� *Client.Phone_Number+6M     5e      $ Device name��6L    6%   �� *Device.Model_Title+6L     5f      $ Device type��6W    6%   �� *Device.Device_Type.Type_Title+6W     5g      $ 
Order date��6D    6%   �� *
Order_Date+6D     5h      $ Status��6F    6%   �� *Status.Title+6F   4	  .System.Windows.Controls.DataGridTemplateColumn	  5i      $ Action��6)    	  CellTemplate 5j      �� 5k      .R�5l      � .+�5m   "   �� -   5        
���   �  MaterialDesignFlatButton#��[ 5p   %   $
 Edit��5q   %   .��5r   &     $��22��5s   )   $��22��5t   )   $ Pencil=�5u   )   5v   #   5w      5x      5z      5|      �� 5�   
   -   5        $��2��5�      $��	0,0,40,40q�5�      $��Right=�5�      $��Bottom=�5�       , (MaterialDesignFloatingActionAccentButton#��[ 5�      $ 	Add order��5�      .��5�        $��30��5�      $��30��5�      $
 Plus=�5�      5�      5�      5�      
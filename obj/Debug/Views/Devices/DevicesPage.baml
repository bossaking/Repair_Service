   M S B A M L   `   `   `  ����I  ERepair_Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Repair_ServiceRepair_Service  5           Repair_Service.DevicesPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Repair_Service     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      -   5          N� 
Background
  ����� N� FontSize$ 16(�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��Center=�5      $��Center=�5      $��30(�5      .��6   	DEVICES5      �� 5   
   -   5        $��0��5       $
��10,0q�5!      $
��Left=�5"      $��Center=�5#      
���   � �� IsCancel .    MaterialDesignIconButton#��[  5'       � ToolTip$
 Back��5(      .��5)      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�6&   5*      &   System.Windows.Controls.DataGrid  5.   
   -   5        $��DataGrid��5/      $��1��50      $
��auto��51      $��5,5,5,5q�52      $��Center=�53      $	��Top=�54         AutoGenerateColumns .     CanUserResizeColumns .     CanUserResizeRows .  	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 58      $��16(�59      
   
IsReadOnly
 .    Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	Id_Device+6C     5=      $ Model title��6E    6%   �� *Model_Title+6E     5>      $ 
Type title��6P    6%   �� *Device_Type.Type_Title+6P     5?      $ Brand title��6L    6%   �� *Device_Brand.Title+6L   4  .System.Windows.Controls.DataGridTemplateColumn  5@      $ Action��6)      CellTemplate 5A      �� 5B      .R�5C      � .+�5D   "   �� -   5        $��0,0,15,0q�5E   %   $��0q�5F   %   
���   �  MaterialDesignFlatButton#��[ 5I   %   $
 Edit��5J   %   .��5K   &     $��22��5L   )   $��22��5M   )   $ Pencil=�5N   )   5O   #   �� 5P   "   -   5        $��0q�5Q   %   
���   �#��[ 5T   %   $ Delete��5U   %   .��5V   &     $��22��5W   )   $��22��5X   )   $ Delete=�5Y   )   5Z   #   5[      5\      5^      5`      �� 5d   
   -   5        $��1��5e      $��	0,0,40,40q�5f      $��Right=�5g      $��Bottom=�5h       �� 	IsDefault .  , (MaterialDesignFloatingActionAccentButton#��[ 5k      $ 
Add device��5l      .��5m        $��30��5n      $��30��5o      $
 Plus=�5p      5q      5s      5u      
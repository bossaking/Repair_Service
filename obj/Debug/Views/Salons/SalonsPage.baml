   M S B A M L   `   `   `  ����I  ERepair_Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Repair_ServiceRepair_Service  5          Repair_Service.SalonsPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Repair_Service     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        N� 
Background
  ����� N� FontSize$ 16(�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��Center=�5      $��Center=�5      $��30(�5      .��6   SALONS5      �� 5   
   -   5        $��0��5      $
��10,0q�5      $
��Left=�5       $��Center=�5!      
���   � �� IsCancel .    MaterialDesignIconButton#��[  5%       � ToolTip$
 Back��5&      .��5'      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�6&   5(      &   System.Windows.Controls.DataGrid  5,   
   -   5        $��DataGrid��5-      $��1��5.      $
��auto��5/      $��5,5,5,5q�50      $��Center=�51      $	��Top=�52         AutoGenerateColumns .     CanUserResizeColumns .     CanUserResizeRows .  	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 56      $��16(�57      
   
IsReadOnly
 .    Columns 59      0  *System.Windows.Controls.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6B   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
Id_Salon+6B     5;      $ Salon title��6?    6%   �� *Title+6?     5<      $ Location��6B    6%   �� *
Location+6B   4  .System.Windows.Controls.DataGridTemplateColumn  5=      $ Action��6)      CellTemplate 5>      �� 5?      .R�5@      � .+�5A   "   �� -   5        $��0,0,15,0q�5B   %   $��0q�5C   %   
���   �  MaterialDesignFlatButton#��[ 5F   %   $
 Edit��5G   %   .��5H   &     $��22��5I   )   $��22��5J   )   $ Pencil=�5K   )   5L   #   �� 5M   "   -   5        $��0q�5N   %   
���   �#��[ 5Q   %   $ Delete��5R   %   .��5S   &     $��22��5T   )   $��22��5U   )   $ Delete=�5V   )   5W   #   5X      5Y      5[      5]      �� 5a   
   -   5        $��1��5b      $��	0,0,40,40q�5c      $��Right=�5d      $��Bottom=�5e       �� 	IsDefault .  , (MaterialDesignFloatingActionAccentButton#��[ 5h      $ 
Add salons��5i      .��5j        $��30��5k      $��30��5l      $
 Plus=�5m      5n      5p      5r      
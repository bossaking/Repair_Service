   M S B A M L   `   `   `  ����I  ERepair_Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Repair_ServiceRepair_Service  5          Repair_Service.RolesPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Repair_Service     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        N� 
Background
  ����� N� FontSize$ 16(�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��Center=�5      $��Center=�5      $��30(�5      .��6   ROLES5      �� 5   
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
 .    Columns 59      0  *System.Windows.Controls.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6A   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	Id_Role+6A     5;      $ 
Role title��6?    6%   �� *Title+6?   4  .System.Windows.Controls.DataGridTemplateColumn  5<      $ Action��6)      CellTemplate 5=      �� 5>      .R�5?      � .+�5@   "   �� -   5        $��0,0,15,0q�5A   %   $��0q�5B   %   
���   �  MaterialDesignFlatButton#��[ 5E   %   $
 Edit��5F   %   .��5G   &     $��22��5H   )   $��22��5I   )   $ Pencil=�5J   )   5K   #   �� 5L   "   -   5        $��0q�5M   %   
���   �#��[ 5P   %   $ Delete��5Q   %   .��5R   &     $��22��5S   )   $��22��5T   )   $ Delete=�5U   )   5V   #   5W      5X      5Z      5\      �� 5`   
   -   5        $��1��5a      $��	0,0,40,40q�5b      $��Right=�5c      $��Bottom=�5d       �� 	IsDefault .  , (MaterialDesignFloatingActionAccentButton#��[ 5g      $ Add role��5h      .��5i        $��30��5j      $��30��5k      $
 Plus=�5l      5m      5o      5q      
   M S B A M L   `   `   `  ����I  ERepair_Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Repair_ServiceRepair_Service  5      "    Repair_Service.EmployeesPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Repair_Service     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        N� 
Background
  ����� N� FontSize$ 16(�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��Center=�5      $��Center=�5      $��30(�5      .��6   	EMPLOYEES5      �� 5   
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
 .    Columns 59      0  *System.Windows.Controls.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6E   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Id_Employee+6E     5;      $
 Name��6>    6%   �� *Name+6>     5<      $ Surname��6A    6%   �� *	Surname+6A     5=      $ Salon��6N    6%   �� *Employee_Salon.Title+6N     5>      $
 Role��6M    6%   �� *Employee_Role.Title+6M   4  .System.Windows.Controls.DataGridTemplateColumn  5?      $ Action��6)      CellTemplate 5@      �� 5A      .R�5B      � .+�5C   "   �� -   5        $��0,0,15,0q�5D   %   $��0q�5E   %   
���   �  MaterialDesignFlatButton#��[ 5H   %   $
 Edit��5I   %   .��5J   &     $��22��5K   )   $��22��5L   )   $ Pencil=�5M   )   5N   #   �� 5O   "   -   5        $��0q�5P   %   
���   �#��[ 5S   %   $ Delete��5T   %   .��5U   &     $��22��5V   )   $��22��5W   )   $ Delete=�5X   )   5Y   #   5Z      5[      5]      5_      �� 5c   
   -   5        $��1��5d      $��	0,0,40,40q�5e      $��Right=�5f      $��Bottom=�5g       �� 	IsDefault .  , (MaterialDesignFloatingActionAccentButton#��[ 5j      $ Add employee��5k      .��5l        $��30��5m      $��30��5n      $
 Plus=�5o      5p      5r      5t      
   M S B A M L   `   `   `  ����I  ERepair_Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Repair_ServiceRepair_Service  5      0    *Repair_Service.ChooseExisitingClientWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Repair_Service     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      -   5          � Title$#  Repair Service: Choose client��5	      $	��800��5
      $	��450��5       � WindowStartupLocation$ CenterOwner=�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��Center=�5      $��Center=�5      $��30(�5      .��6   CHOOSE CLIENT5      �� 5    
   -   5        $��0��5!      $
��10,0q�5"      $
��Left=�5#      $��Center=�5$      
���   � �� IsCancel .    MaterialDesignIconButton#��[  5(       � ToolTip$
 Back��5)      .��5*      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�6&   5+      &   System.Windows.Controls.DataGrid  5/   
   -   5        $��ClientsDataGrid��50      $��1��51      $
��auto��52      $��5,5,5,5q�53      $��Center=�54      $	��Top=�55         AutoGenerateColumns .     CanUserResizeColumns .     CanUserResizeRows .  	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 59      $��16(�5:      
   
IsReadOnly
 .    Columns 5<      0  *System.Windows.Controls.DataGridTextColumn  5=      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	Id_Client+6C     5>      $ Client name��6>    6%   �� *Name+6>     5?      $ Client surname��6A    6%   �� *	Surname+6A     5@      $ Client phone number��6F    6%   �� *Phone_Number+6F   4  .System.Windows.Controls.DataGridTemplateColumn  5A      $ Action��6)      CellTemplate 5B      �� 5C      .R�5D      � $��Center=�6(   .+�5E   "   �� -   5        $��0q�5F   %   
���   �  MaterialDesignFlatButton#��[ 5I   %   $ Choose client��5J   %   .��5K   &     $��22��5L   )   $��22��5M   )   $ AccountPlus=�5N   )   5O   #   5P      5Q      5S      5U      5W      5Y      
   M S B A M L   `   `   `  ���� ?  ;shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:shopshop      shop.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $localclr-namespace:shop     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$
  Menu��$	��750��$
��1000�� � WindowStyle$ ThreeDBorderWindow=�.��]� ��. ���#56cbf9.+��� -    ��Name$ TopMenu��$	��Top=�$	��130�����#56cbf9.+��� -    ��Name$ ButtonStaff��$��30��$��50�����#4B0082
 �� Top$ 15�� �� Right$ 30��   MaterialDesignFlatButton#��[  $�� Staff����  �� Orientation$ 
Horizontal=�$ 20�� �� Left$ 30��.+��� -    ��Name$ 	SearchToy��$	��150��$��30��
����·����#4B0082	 �� TextWrapping$
	 Wrap=��� -   $ ButtonSearch��$��50�����#b388eb���#4B0082$��Search���� $ 
Horizontal=�
 �� Bottom$
 15��$ 30��.+��� -    ��Name$ CategoryList�� �� 
IsEditable .  �� 
IsReadOnly . $	��100�� �� Text$ Category�����#4B0082$
��Bold"����#4B0082.@��� .��all�� .��Soft�� .��Robots�� .��
Antistress�� -    ��Name$ 
BottomMenu��$��Bottom=�$��80�����#56cbf9.+��� $ 
Horizontal=�$��Right=�$��Center=�$
��auto��$��	0 10 30 0q�.+��� -   $ PreviousPage��$��30��$��Previous Page�����#4B0082���#b388eb�� -   $ NextPage��$��20��$��	Next Page�����#4B0082���#b388eb�� $ 
Horizontal=�$��Center=�.+��� -	    ��Name$ NowPage��$��10(����#4B0082$
��Bold"��� -
   $ Allpages��$��10(����#4B0082$
��Bold"��  � ShowGridLines .  $��	20 0 20 0q� � RowDefinitions �� ��  � ColumnDefinitions �� �� �� �� �� .+��� -    ��Name$ Item1��$��0��$��0��
�������$
��Auto��$
��Auto��$��10q� �� CornerRadius$ 5�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 20Q�   Color$ #0000CD��   ShadowDepth$ 0Q�._�]� ��. .+��� -   $ ToyInfo1��$��Bottom=�$��More information�����#800080���#ff729f$��0 5 0 0q��� -   $ 	ToyPrice1��$��Bottom=� �� TextAlignment$ Center=�$
��Bold"�$��0 5 0 0q��� -   $ ToyName1��$��Bottom=�$ Center=�$
��Wrap=��� -   $ ToyId1��$��Bottom=�$��5��$y�Hidden=��� -    ��Name$ 	ToyImage1��$	��150��$	��200���� -   $ Item2��$��1��$��0��
�������$
��Auto��$
��Auto��$��10q�$ 5��   $ 20Q�$ #0000CD��$ 0Q�._�]� .+��� -   $ ToyInfo2��$��Bottom=�$��More information�����#800080���#ff729f$��0 5 0 0q��� -   $ 	ToyPrice2��$��Bottom=�$ Center=�$
��Bold"�$��0 5 0 0q��� -   $ ToyName2��$��Bottom=�$ Center=�$
��Wrap=��� -   $ ToyId2��$��Bottom=�$��5��$y�Hidden=��� -   $ 	ToyImage2��$	��150��$	��200���� -   $ Item3��$��2��$��0��
�������$
��Auto��$
��Auto��$��10q�$ 5��   $ 20Q�$ #0000CD��$ 0Q�._�]� .+��� -   $ ToyInfo3��$��Bottom=�$��More information�����#800080���#ff729f$��0 5 0 0q��� -   $ 	ToyPrice3��$��Bottom=�$ Center=�$
��Bold"�$��0 5 0 0q��� -   $ ToyName3��$��Bottom=�$ Center=�$
��Wrap=��� -   $ ToyId3��$��Bottom=�$��5��$y�Hidden=��� -   $ 	ToyImage3��$	��150��$	��200���� -   $ Item4��$��3��$��0��
�������$
��Auto��$
��Auto��$��10q�$ 5��   $ 20Q�$ #0000CD��$ 0Q�._�]� .+��� -   $ ToyInfo4��$��Bottom=�$��More information�����#800080���#ff729f$��0 5 0 0q��� -   $ 	ToyPrice4��$��Bottom=�$ Center=�$
��Bold"�$��0 5 0 0q��� -    $ ToyName4��$��Bottom=�$ Center=�$
��Wrap=��� -!   $ ToyId4��$��Bottom=�$��5��$y�Hidden=��� -"   $ 	ToyImage4��$	��150��$	��200���� -#   $ Item5��$��4��$��0��
�������$
��Auto��$
��Auto��$��10q�$ 5��   $ 20Q�$ #0000CD��$ 0Q�._�]� .+��� -$   $ ToyInfo5��$��Bottom=�$��More information�����#800080���#ff729f$��0 5 0 0q��� -%   $ 	ToyPrice5��$��Bottom=�$ Center=�$
��Bold"�$��0 5 0 0q��� -&   $ ToyName5��$��Bottom=�$ Center=�$
��Wrap=��� -'   $ ToyId5��$��Bottom=�$��5��$y�Hidden=��� -(   $ 	ToyImage5��$	��150��$	��200���� -)   $ Item6��$��0��$��1��
�������$
��Auto��$
��Auto��$��10q�$ 5��   $ 20Q�$ #0000CD��$ 0Q�._�]� .+��� -*   $ ToyInfo6��$��Bottom=�$��More information�����#800080���#ff729f$��0 5 0 0q��� -+   $ 	ToyPrice6��$��Bottom=�$ Center=�$
��Bold"�$��0 5 0 0q��� -,   $ ToyName6��$��Bottom=�$ Center=�$
��Wrap=��� --   $ ToyId6��$��Bottom=�$��5��$y�Hidden=��� -.   $ 	ToyImage6��$	��150��$	��200���� -/   $ Item7��$��1��$��1��
�������$
��Auto��$
��Auto��$��10q�$ 5��   $ 20Q�$ #0000CD��$ 0Q�._�]� .+��� -0   $ ToyInfo7��$��Bottom=�$��More information�����#800080���#ff729f$��0 5 0 0q��� -1   $ 	ToyPrice7��$��Bottom=�$ Center=�$
��Bold"�$��0 5 0 0q��� -2   $ ToyName7��$��Bottom=�$ Center=�$
��Wrap=��� -3   $ ToyId7��$��Bottom=�$��5��$y�Hidden=��� -4   $ 	ToyImage7��$	��150��$	��200���� -5   $ Item8��$��2��$��1��
�������$
��Auto��$
��Auto��$��10q�$ 5��   $ 20Q�$ #0000CD��$ 0Q�._�]� .+��� -6   $ ToyInfo8��$��Bottom=�$��More information�����#800080���#ff729f$��0 5 0 0q��� -7   $ 	ToyPrice8��$��Bottom=�$ Center=�$
��Bold"�$��0 5 0 0q��� -8   $ ToyName8��$��Bottom=�$ Center=�$
��Wrap=��� -9   $ ToyId8��$��Bottom=�$��5��$y�Hidden=��� -:   $ 	ToyImage8��$	��150��$	��200���� -;   $ Item9��$��3��$��1��
�������$
��Auto��$
��Auto��$��10q�$ 5��   $ 20Q�$ #0000CD��$ 0Q�._�]� .+��� -<   $ ToyInfo9��$��Bottom=�$��More information�����#800080���#ff729f$��0 5 0 0q��� -=   $ 	ToyPrice9��$��Bottom=�$ Center=�$
��Bold"�$��0 5 0 0q��� ->   $ ToyName9��$��Bottom=�$ Center=�$
��Wrap=��� -?   $ ToyId9��$��Bottom=�$��5��$y�Hidden=��� -@   $ 	ToyImage9��$	��150��$	��200���� -A   $ Item10��$��4��$��1��
�������$
��Auto��$
��Auto��$��10q�$ 5��   $ 20Q�$ #0000CD��$ 0Q�._�]� .+��� -B   $ 	ToyInfo10��$��Bottom=�$��More information�����#800080���#ff729f$��0 5 0 0q��� -C   $ 
ToyPrice10��$��Bottom=�$ Center=�$
��Bold"�$��0 5 0 0q��� -D   $ 	ToyName10��$��Bottom=�$ Center=�$
��Wrap=��� -E   $ ToyId10��$��Bottom=�$��5��$y�Hidden=��� -F   $ 
ToyImage10��$	��150��$	��200��
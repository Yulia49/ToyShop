   M S B A M L   `   `   `  ���� ?  ;shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:shopshop      shop.EmployeeWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $localclr-namespace:shop     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � 
ResizeMode$  NoResize=� � Title$ EmployeeWindow��$	��400��$	��400�� � WindowStyle$ ThreeDBorderWindow=�.��� ���#56cbf9.+��� ���#56cbf9$��Stretch=�.+��� -    ��Name$ BactToMenu3��$
��Back��$
��Left=����#4B0082$��30��   MaterialDesignFlatButton#��[  �� $��Change ammount of toys��$��20(����#4B0082$��10q�� $��10 0 0 0q�$��Stretch=� � ColumnDefinitions �� �� �� .+��� $��0��$��10q�$��Stretch=� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ Purple��   ShadowDepth$ 0Q�.+��� $��Articul��$��20�����#b388eb$��0 0 0 5q��� -   	 ��Name$	 
toyarticle��$��30��)  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Enter articul��
��������� $��1��$��10q�$��Stretch=�   $ 5Q�$ Purple��$ 0Q�.+��� $��20�����#b388eb$��0 0 0 5q�Amount�� -   $	 	toyamount��$��30��$
 Enter amount��
��������� -   $ ButChangeAmount��$��2��$��20��$��Stretch=�$��10q�$��Apply��$��Bottom=����#b388eb���#4B0082�� $%��Find information about supplier��$��20(����#4B0082$��10q�� $��10 0 0 0q� �� �� .+��� $��0��$��10q�$��Stretch=�   $ 5Q�$ Purple��$ 0Q�.+��� $
��Name��$��20�����#b388eb$��0 0 0 5q��� -   $	 suppliername��$��30��$
 
Enter name��
��������� -   $ ButFindSupplier��$��1��$��20��$��80��$
��Find��$��10q�$��Bottom=����#b388eb���#4B0082�� -   $ AddEmployee��$��Add Employee��$
��Left=�$��20q����#b388eb���#4B0082
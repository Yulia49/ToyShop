   M S B A M L   `   `   `  ����?  ;shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:shopshop  5   	       shop.EmployeeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:shop     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � 
ResizeMode$  NoResize=�5   	    � Title$ EmployeeWindow��5
   	   $	��400��6    $	��400��6-    � WindowStyle$ 
ToolWindow=�69   .��5      � ���#56cbf9.+�5   
   �� ���#56cbf9$��Stretch=�6*   .+�5      �� -   5         ��Name$ BactToMenu3��5      $
��Back��6D   $
��Left=�6S   ���#4B0082$��30��6�      MaterialDesignFlatButton#��[  6�   �� 5      $��Change ammount of toys��6   $��20(�66   ���#4B0082$��10q�6Y   � 5      $��10 0 0 0q�6   $��Stretch=�6%    � ColumnDefinitions 5      �� 5      �� 5      �� 5      .+�5      �� $��0��6   $��10q�6-   $��Stretch=�69    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6+      Color$ Purple��6:      ShadowDepth$ 0Q�6I   .+�5      �� $��Articul��6    $��20��6/   ���#b388eb$��0 0 0 5q�6S   �� 5      -   5        	 ��Name$	 
toyarticle��5      $��30��62   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Enter articul��6A   
�������6p   5      �� 5      $��1��6   $��10q�6-   $��Stretch=�69    5        5      $ 5Q�6+   $ Purple��6:   $ 0Q�6I   .+�5       �� $��20��6    ���#b388eb$��0 0 0 5q�6D   Amount6]   �� 5!      -   5        $	 	toyamount��5!      $��30��61   $
 Enter amount��6@   
�������6n   5"      �� 5#      -   5        $ ButChangeAmount��5#   )   $��2��6   $��20��6`   $��Stretch=�6o   $��10q�6�   $��Apply��6�   $��Bottom=�6�   ���#b388eb���#4B00826�   5$      �� 5%      $%��Find information about supplier��6   $��20(�6?   ���#4B0082$��10q�6b   � 5&      $��10 0 0 0q�6    5'      �� 5(      �� 5)      .+�5+      �� $��0��6   $��10q�6-   $��Stretch=�69    5,        5-      $ 5Q�6+   $ Purple��6:   $ 0Q�6I   .+�5/      �� $
��Name��6    $��20��6,   ���#b388eb$��0 0 0 5q�6P   �� 50      -   5        $	 suppliername��50      $��30��64   $
 
Enter name��6C   
�������6o   51      �� 52      -   5        $ ButFindSupplier��52      $��1��62   $��20��6`   $��80��6o   $
��Find��6}   $��10q�6�   $��Bottom=�6�   ���#b388eb���#4B00826�   53      �� 54      -   5        $ AddEmployee��54      $��Add Employee��6E   $
��Left=�6\   $��20q�6w   ���#b388eb���#4B00826�   55      56      57      
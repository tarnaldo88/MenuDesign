   M S B A M L   `   `   `  ����E  AMenuDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MenuDesign
MenuDesign  5   	   E'clr-namespace:MenuDesign.MVVM.ViewModelMenuDesign.MVVM.ViewModel  5   	       MenuDesign.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MenuDesign     5   	   =	viewModel'clr-namespace:MenuDesign.MVVM.ViewModel     5   	   $	��600��5	   	   $	��920��6     � WindowStyle$
  None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      -  'MenuDesign.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 20��5      ._�5      �  � ColumnDefinitions 5   
   �� 5      $	��220 �6   �� 5       � RowDefinitions 5      �� 5      $��75 �6    �� 5      .+�5   
   �� $��Torres Goal Tracker��6   $��Center=�5      $
��Left=�5      
�������$��22(�5!      $��20,0,0,0q�5"      �� 5#   
   $��1��6   .+�5$      	� $
��Home��6   $��50��5%      $��15(�5&      
�������   MenuButtonTheme#��[  5(       d� 	IsChecked$
 TrueY�5)      ��5*      �� *HomeViewCommand+	� 5+      $��Tasks��6   $��50��5,      $��15(�5-      
�������#��[  5/      ��50      �� *TasksViewCommand+	� 51      $��Completed Tasks��6   $��50��52      $��15(�53      
�������#��[  55      ��56      �� *CompViewCommand+58      �� 5:      $	��250��6   $��40��5;      $��Center=�5<      $
��Left=�5=      $��5,0,0,0q�5>      $��1��5?        ModernTextBox#��[ 5@      �� 5B      $��1��6   $��1��5C      $��10q�5D      ��5E      �� *CurrentView+5F      5G      5H      
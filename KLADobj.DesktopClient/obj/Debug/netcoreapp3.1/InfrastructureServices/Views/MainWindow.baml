   M S B A M L   `   `   `  ����P  LKLADobj.DesktopClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:KLADobj.DesktopClientKLADobj.DesktopClient  5   	   &     KLADobj.DesktopClient.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:KLADobj.DesktopClient     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         Montserrat-Medium��%S   &	        *�5
   
   1-pack://application:,,,/Fonts/#Med Uch Regular)�5      5      .��5      � #��[  6   $��14(�6E    � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��5q�6"   
���/���
���������6Z   �� *
KLADobjs+ �� SelectedItem 6{   �� *CurrentKLADobj+��5      �� 5      .R�5      �� $��5q�6!   .+�5      �� $��14(�6$   ��62   ��  �� Path$
 Name�5      5      5      �� 5   
   $��1��6   $��0,0,0,0q�6L    � DataContext 6%   �� *CurrentKLADobj+.+�5      ��  �� Padding$ 3q�6   $
��Bold"�6$   $��
More info:��66   $��Center=�6H   �� 5       $ 2q�6   $
��Wrap=�6$   ��68   ��  �� StringFormat$ 	Name: {0}��$
 Name��� 5!      $ 2q�6   $
��Wrap=�6$   ��68   �� $ Address: {0}��$ Address��� 5"      $ 2q�6   $
��Wrap=�6$   ��68   �� $ ChillType: {0}��$ 	ChillType��� 5#      $ 2q�6   $
��Wrap=�6$   ��68   �� $ 	Free: {0}��$
 Free�5$      5%      5&      
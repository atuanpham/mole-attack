   M S B A M L   `   `   `  ����M  IWpfPageTransitions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS<clr-namespace:WpfPageTransitions;assembly=WpfPageTransitionsWpfPageTransitions  5   	   C ?MenuGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MenuGameMenuGame 5   	      MenuGame.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F   XpageTransitions<clr-namespace:WpfPageTransitions;assembly=WpfPageTransitions     5   	   (localclr-namespace:MenuGame     5   	   -   5          � Title$  
MainWindow��5   	   $	��620��6   $	��980��6)   $y�Visible=�65    � AllowsTransparency .  � WindowStyle$
 None=�6d    � WindowStartupLocation$ CenterScreen=�6w    J� 	AllowDrop . ���	#00000000 � 
ResizeMode$ NoResize=�6�   ��6�   Z� ��6�   Z�  � 	Resources 5         ButtonStyle1 �� 
TargetType �� Property	 �� Value
 �� 
TargetType ��Name �� RadiusY �� RadiusX �� EndPoint �� 
StartPoint � Color � Offset ��Name J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName��%�  &	        �� 5	      " ��6"   .�5
      ��  � ��	 5   	   �� 5   
   "
 ��6   .R�5      � .+�5      �� $ 	rectangle��6   $	 5.5��6)   $	 5.5��67   
���   ���5      �� 5      $ 0.5,1&�6"   $ 0.5,0&�63   .��5      � $ 	#FF055B05��6   $ 0Q�6.   � 5      $ 	#FF377A37��6   $ 1Q�6.   5      5      �� 5      $ contentPresenter��6   #��z��67   ��. # z 6�   #��z��6�   5       5      P� 5       �@J�	IsFocused . 6)   P� 5       �@��IsDefaulted . 6+   P� 5       �@J�IsMouseOver . . �5      �� $ 	rectangle��6$    � ��	 5      �� 5      $ 0.5,1&�6#   $ 0.5,0&�64   .��5       � $ 	#FFF70000��6   $ 0.013Q�6/   � 5!      $ 	#FF110707��6   $ 1Q�6/   5"      5$      �� 5%      $ 	rectangle��6&    � ��	 �	#FFF3EDED6=   5&      P� 5'       � �� . . �5(      �� $ contentPresenter��6+    �@J�OpacityMask	 �	#FFEA0C0C6I   �� 5)      $ 	rectangle��6&    � ��	 �	#FFEE10106=   �� 5*   
   $ 	rectangle��6!    � ��	 �	#FF054D1668   5+      P� 5,       � {� .  6)   5.      50   	   51      52      .��53      �� -   5        $��
mainWindow��53   
   $��10q�6   .+�55   
   �� $	��600��6   $��Images/Backgroundmenu.png��6   $
��Fill=�6@   $	��960��6O   '   !WpfPageTransitions.PageTransition  57   
   -   5          Name$ pageTransitionControl��57   )      TransitionType$ GrowAndFade=�6H   �� 58   
   -   5        $ Title��58      ���	#FFF4F4F5$
��Left=�64   $��40��6O   
���   �$	��Top=�6j   $	��960��6�    J� Opacity$ 0Q�6�    K� ZIndex$
 9999��6�   �� 5:   
   -   5         ��Name$ btnExit��5:      $��X��6"   $��30��6.   #���   6:   $	��Top=�6a   $��40��6y   $��Arial)�6�   $��21.333(�6�   $
��Bold"�6�   $��RightToLeft=�6�   $��Right=�6�   $
 9999��6	   �� Left$	 920��6  ��5;      �� 5<      $ 0.5,1&�6&   $ 0.5,0&�67   .��5=      � $ Black��6#   $ 0Q�61   � 5>      $ White��6#   $ 1Q�61   5?      5A      �� 5C   
   -   5        $ btnMin��5C      $��_��6!   $��30��6-   #���   69   $	��Top=�6`   $��40��6x   $��Arial)�6�   $��21.333(�6�   $��Right=�6�   $
��Bold"�6�   $
 9999��6�   $	 875��6�   ��5D      �� 5E      $ 0.5,1&�6&   $ 0.5,0&�67   .��5F      � $ Black��6#   $ 0Q�61   � 5G      $ White��6#   $ 1Q�61   5H      5J       J� Effect 5L      3  -System.Windows.Media.Effects.DropShadowEffect  5M      -   5        DS��   
BlurRadius$ 15Q�5M   "       ShadowDepth$  2Q�62   !   Color$! Black��6B   6R   5O      5Q      
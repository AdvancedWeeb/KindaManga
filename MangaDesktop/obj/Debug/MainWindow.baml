   M S B A M L   `   `   `  ����G  CMangaDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MangaDesktopMangaDesktop  5   	       MangaDesktop.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MangaDesktop     5   	     � Title$  Manga Desktop��5   	   $	��500��6   $	��900��6,    � 
ResizeMode$ CanMinimize=�68    � 	Resources 5	         mainDataTemplate  mainItemTemplate  
readButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property	 P� Value

 � Tag��%w  &	        &	 -     &	 Z     '�� �    7  �� 5
   
   .R�5      �� 6   5      �� 5   
   .R�5      � 6   5      �� 5   
   " ��6#   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� #��z��6)   5      5      �� 5       � ��$
 12.4(�6)   �� 5       � ��
 �  ��6+    5      P� 5       �@J�IsMouseOver	 . . �5      ��  � ��
 � � �63   5      5      �� 5    
   " ��6   .�5!      ��  � �� 5"      �� 5#      " ��6&   .R�5$      � .+�5%      �� $	��125��6$   $	��119��60   ��6=   �� *Image+6X   �� 5&      $��Name:��6(   $��16(�65   �� 5'      $	��150��6)   $��15(�6K   $��24��6Y   ��65   �� *Name+6Y   �� 5(      $��16(�6(   $��Score:��66   �� 5)      $��16(�6(   $	��122��6M   $��0 0 5 0q�6Y   ��66   �� *Score+6Y   �� 5*      -   5        $��20(�5*   d   $��Read!��6r   8��  $��34��6�   $	��150��6�   
 6I   �� *
ReadingUrl+6�   5+      5,      5.      �� 5/       � ��$	 270��6'   �� 50       � ��$	 170��6&   51      52      .��54      �  � RowDefinitions 55   
   �� 56      �� 57      $	��410 �6   .+�59   
   �� -   5        $��	SearchBox��59      
���   �$��200,5,147,22q�67   �� 5:   
   -   5        $��Search��5:      $
��Left=�6"   $��	767,6,0,0q�6=   $	��Top=�6P   $	��100��6h   $��25��6t   6�   �� 5;   
   $&�� Enter a manga's name right here:��6   $��	0,4,700,0q�6;   $	��Top=�6N   �� 5<   
   $��1��6   .��5=      �� -   5        $��MangasControl��5=   �   $��1��6   #��[  6(   #��[ 6Y   5>      5?      5@      5A      
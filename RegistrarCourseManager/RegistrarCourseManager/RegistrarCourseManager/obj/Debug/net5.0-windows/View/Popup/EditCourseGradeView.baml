   M S B A M L   `   `   `  ����Q  MRegistrarCourseManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:RegistrarCourseManager.ViewModel.Popup&RegistrarCourseManager.ViewModel.Popup  5      _4clr-namespace:RegistrarCourseManager.ViewModel.Popup&RegistrarCourseManager.ViewModel.Popup  5      @    :RegistrarCourseManager.ViewModel.Popup.EditCourseGradeView   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:RegistrarCourseManager.ViewModel.Popup     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      J	viewmodel4clr-namespace:RegistrarCourseManager.ViewModel.Popup     5      
������ .��5      � 
������   � RowDefinitions  5   
   �� 5      �� 5      $
��auto �6   .+�5   
   �� $	��220��5      $��0,15,0,0q�5      $��Center=�5       �� Orientation$ Vertical=�5      .+�5      �� $ 
Horizontal=�6   .+�5      �� $��0,0,20,0q�6   $��Stretch=�6/   .+�5      �� $	��100��5      $	��0,5q�5      $��Stretch=�5      
���   �$��0,0,0,1q�5      ._�5       �� .+�5!      �� $��0q�5"   !   $��Stretch=�5#   !   ���	#00000000$��Course Prefix��5%   !   $��Bottom=�5&   !   $��12(�5'   !   $��Light"�5(   !   
���   �5)   !   �� 5*      -   5         ��Name$ TextBox_Prefix��5+   !   $��Stretch=�5,   !   $��Stretch=�5-   !   
������ $��0q�5/   !   $��Bottom=�50   !   $��18(�51   !   $��
UltraLight"�52   !   
���   � �� TextAlignment$
 Left=�54   !   55   !   56      57      58      �� 59      .+�5:      �� $	��100��5;      $	��0,5q�5<      
���   �$��0,0,0,1q�5>      ._�5?      �� .+�5@      �� $��0q�5A   !   $��Stretch=�5B   !   ���	#00000000$��
Course Num��5D   !   $��Bottom=�5E   !   $��12(�5F   !   $��Light"�5G   !   
���   �5H   !   �� 5I      -   5        $ TextBox_CourseNum��5J   !   $��Stretch=�5K   !   $��Stretch=�5L   !   
������ $��0q�5N   !   $��Bottom=�5O   !   $��18(�5P   !   $��
UltraLight"�5Q   !   
���   �$
 Left=�5S   !   5T   !   5U      5V      5W      5X      �� 5Y      $ 
Horizontal=�6   .+�5Z      �� $��0,0,20,0q�6   $��Stretch=�6/   .+�5[      �� $	��100��5\      $	��0,5q�5]      $��Stretch=�5^      
���   �$��0,0,0,1q�5`      ._�5a      �� .+�5b      �� $��0q�5c   !   $��Stretch=�5d   !   ���	#00000000$��Semester��5f   !   $��Bottom=�5g   !   $��12(�5h   !   $��Light"�5i   !   
���   �5j   !   �� 5k      -   5        $ TextBox_Semester��5l   !   $��Stretch=�5m   !   $��Stretch=�5n   !   
������ $��0q�5p   !   $��Bottom=�5q   !   $��18(�5r   !   $��
UltraLight"�5s   !   
���   �$
 Left=�5u   !   5v   !   5w      5x      5y      �� 5z      .+�5{      �� $	��100��5|      $	��0,5q�5}      
���   �$��0,0,0,1q�5      ._�5�      �� .+�5�      �� $��0q�5�   !   $��Stretch=�5�   !   ���	#00000000$
��Year��5�   !   $��Bottom=�5�   !   $��12(�5�   !   $��Light"�5�   !   
���   �5�   !   �� 5�      -   5        $ TextBox_Year��5�   !   $��Stretch=�5�   !   $��Stretch=�5�   !   
������ $��0q�5�   !   $��Bottom=�5�   !   $��18(�5�   !   $��
UltraLight"�5�   !   
���   �$
 Left=�5�   !   5�   !   5�      5�      5�      5�      �� 5�      .+�5�      �� $	��100��5�      $	��0,5q�5�      
���   �$��0,0,0,1q�5�      ._�5�      �� .+�5�      �� $��0q�5�      $��Stretch=�5�      ���	#00000000$��Grade��5�      $��Bottom=�5�      $��12(�5�      $��Light"�5�      
���   �5�      �� 5�      -   5        $ TextBox_Grade��5�      $��Stretch=�5�      $��Stretch=�5�      
������ $��0q�5�      $��Bottom=�5�      $��18(�5�      $��
UltraLight"�5�      
���   �$
 Left=�5�      5�      5�      5�      5�      5�      �� 5�   
   -   5        $��1��5�      $��75��5�      $	��0,8q�5�         maroonBackground#��[  5�        RoundButton#��[ 5�      .��5�      �� $��Submit��5�      $��12(�5�      $��Light"�5�      
�������5�      5�      5�      5�      
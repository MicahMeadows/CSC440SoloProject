   M S B A M L   `   `   `  ����Q  MRegistrarCourseManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:RegistrarCourseManager.CustomControl$RegistrarCourseManager.CustomControl  5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0894    .RegistrarCourseManager.CustomControl.TabButton  �� 
TargetType �� Property �� Value �� 
TargetType �Name �� Color J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   
BlurRadius   	Direction	   Opacity
 � ColumnDefinitions �� BitmapScalingMode �� RelativeSource ��Name    Title'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� 
TargetName �� TargetProperty	 �� To g� Duration	 W� To�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      <local2clr-namespace:RegistrarCourseManager.CustomControl  5      %�  '         �� 5      "    6   .�5   
   ��  � �� 5      �� 5	      "   6"   .R�5      � $ Grid_TabButton��5      $��42��5      $��0,0,0,15q�5      ��5      �� 5      BackgroundColor��$ Transparent��6G    5        5      
DropShadow��$ 4Q�5   !   $	 270Q�5   !   $		 .25Q�5   !   
 5      �� 5      $��1* �6/   �� 5      $��3* �6/   .+�5      �� $��0��5      $��24��5      $��8q�5       $��Center=�5!      $ HighQuality=�5"      ��5#      �� *
IconPath+ �� *TemplatedParent+�� 5$      $ Label_Title��5%      $��1��5&      $��Center=�5'      #��z 5(      $��Segoe UI Light)�5)      $��20(�5*      $��
UltraLight"�5+      
�������5,       5-        5.      . 5/   "     Selected��. 50   &   �� .��51   *   �� $ BackgroundColor��52   -   $ Color�53   -    #A9676754   -   $ 0:0:.25D�55   -   W� 57   *   $ 
DropShadow��58   -   $ Opacity�59   -    .255:   -   $ 0:0:.25D�5;   -   5<   '   5=   #     5>   "   
Unselected��. 5?   &   �� .��5@   *   �� $ BackgroundColor��5A   -   $ Color�5B   -    Transparent5C   -   $ 0:0:0D�5D   -   W� 5E   *   $ 
DropShadow��5F   -   $ Opacity�5G   -    05H   -   $ 0:0:0D�5I   -   5K   '   5L   #   5M      5O      5P      5R      5S      5T      
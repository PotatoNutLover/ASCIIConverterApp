   M S B A M L   `   `   `  ����I  EASCIIConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ASCIIConverterASCIIConverter  5   	       ASCIIConverter.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ASCIIConverter     5   	   -   5          � Title$  ASCIIConverter��5   	   $	��560��6    $	��300��6-    � 
ResizeMode$ NoResize=�69    J� 	AllowDrop$
 True��6O   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��63* �6   �� 5      $	��80* �6   �� 5      $	��80* �6   �� 5      $
��223* �6   �� 5      $	��86* �6   �� 5      $	��30* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $
��113* �6#   �� 5      $	��37* �6#   .+�5      �� -   5         ��Name$ 	LabelPath��5   $   $��0��6   $
��Left=�67   $��Center=�6Y   $��10,0,0,0q�6{   ���	#FF363636$��20(�6�   .��6�   Save path...5      �� 5      -   5         ��Name$ ChooseFolderButton��5   %   $��1��6   $��10 15q�6A   $��15(�6P   $��Center=�6^   ���	#FF363636.��6�   ...5      5      � 5   
   $��1��6    5       �� 5!      $��50 �6    �� 5"      $��30 �6     5$      �� 5%      $
��197* �6#   �� 5&      $
��103* �6#   .+�5(      �� $��0��6   $
��Left=�6$   $��Center=�6F   $��10,0,0,0q�6h   ���	#FF363636$��20(�6�   .��6�   Сompression level5*      �� 5+      -   5         ��Name$ TextBoxCompressionLevel��5+   &   $��1��6   $��10q�6G   $	��1.5q�6S   ���	#FF363636���	#FF363636$��Center=�6�   $��Center=�6�   $��15(�6�   $��Calibri)�6�   .��65  15-      �� 5.      -   5        $ ResolutionLabel��5.   1   $��0��6   $��1��6$   ���	#FF646464$��Calibri)�6a   $��Center=�6v   $	��Top=�6�   50      51      � 52   
   $��2��6    53      �� 54      $��50 �6    �� 55      $��30 �6     57      �� 58      $
��130* �6#   �� 59      $
��103* �6#   .+�5;      �� $��0��6   $
��Left=�6$   $��Center=�6F   $��10,0,0,0q�6h   ���	#FF363636$��20(�6�   .��6�   Brightness level5=      �� 5>      -   5         ��Name$ BrightnessSlider��5>   %   $��1��6   $��Center=�6?   
�������
�������$��10q�6�   
�������	 � Minimum$
	 -100Q�6�   
 � Maximum$	
 100Q�6�    � Value$ 0Q�6�    � SmallChange$ .1Q�6�    � LargeChange$ 1Q�6�   6�   �� 5?      -   5        $ BrighnessLabel��5?   1   $��1��6   $��1��6$   ���	#FF646464$��Calibri)�6`   $��Center=�6u   $	��Top=�6�   .��6�   05A      5B      �� 5D   
   $��3��6   $	��1.5q�6   $��10,10,10,10q�64   ���	#FF363636._�5E      �� -   5         ��Name$ PickedImage��5E      $
��Fill=�6)   5F      �� 5G   
   -	   5        $ 	HelpLabel��5G      $��3��6   $��Center=�60   $��Center=�6R   ���	#FF646464$��0,0,0,86q�6�   $��2��6�   .��6�   Drag and Drop the image5I      �� 5J   
   -
   5        $ ConvertButton��5J      $��4��6   $��10,10,10,10q�65   $��50(�6J   $��Calibri)�6X   $��Center=�6m   ���	#FF363636.��6�   	Convert5L      �� 5M   
   -   5        $ ConvertingStateLabel��5M      $��5��6   ���	#FF646464$��Calibri)�6R   $��15(�6g   $��Converting...��6u   $��10 0 0 0q�6�   $y�Hidden=�6�   5N      5P      
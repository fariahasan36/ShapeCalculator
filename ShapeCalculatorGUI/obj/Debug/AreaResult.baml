   M S B A M L   `   `   `  ����M  IShapeCalculatorGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ShapeCalculatorGUIShapeCalculatorGUI  5   	   #    ShapeCalculatorGUI.AreaResult   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ShapeCalculatorGUI     5   	     � Title$  
AreaResult��5   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�5	      
������ .��5      �� ���#555588 �� CornerRadius$ 10��5      ._�5   
   �  � RowDefinitions 5      �� 5      $��60 �6    �� 5      $��94 �6    �� 5      �� 5      $��80 �6    .+�5      �� $��0��6   $��Shape Area Calculator��6%   $��Center=�6B   $��Center=�6_   $��22(�6z   
�������$��0 20 0 0q�6�   �� 5      $��1��6   $
��Left=�6&   $��	20 20 0 0q�6A   .+�5      �� $��Area of Triangle��6   $��Center=�64   $	��Top=�6Q   $
��Bold"�6i   $��14(�6{   
�������6�   �� 5      -   5         ��Name$ TxtTriangleResult��5   J    �� 
IsReadOnly . $
��Left=�6e    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��200��6�    J� RenderTransformOrigin$ 0.507,0.198&�6�      
GenTextBox#��[  6�   ��6   �� *triangleArea+6�   5      �� 5      $��1��6   $��Center=�6&   $��0 20 0 0q�6C   .+�5      �� $��Area of Rectangle��6   $��Center=�65   $	��Top=�6R   $
��Bold"�6j   $��14(�6|   
�������6�   �� 5       -   5        $ TxtRectangleResult��5    K    . $
��Left=�6g   $
 Wrap=�6�   $	��Top=�6�   $	��200��6�   #��[  6�   $ 0.507,0.198&�6�   ��6   �� *rectangleArea+6�   5!      �� 5#      $��1��6   $��Right=�6&   $��	0 20 20 0q�6B   .+�5$      �� $��Area of Circle��6   $��Center=�62   $	��Top=�6O   $
��Bold"�6g   $��14(�6y   
�������6�   �� 5%      -   5        $ TxtCircleResult��5%   6   $
��Left=�6O   $
 Wrap=�6j    . $	��Top=�6�   $	��200��6�   #��[  6�   $ 0.507,0.198&�6�   ��6   �� *
circleArea+6�   5&      �� 5(      $��2��6   $��20 10 20 10q�6&   .+�5)      �� $��All Existing Records��6   
�������$��Center=�6K   &   System.Windows.Controls.DataGrid  5+      -   5          Name$ 	ShapeList��5+      $��Stretch=�62   $��0 10 0 0q�6P   	   AutoGenerateColumns	 .  $��0��6~   $��0��6�   ��. $	��150��6�   $
��Auto=�5,      $
��Auto=�5-      $
��Bold"�69   
   Columns
 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Header$ 	ShapeName��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *	ShapeName+  50      $ Side1��61    6@   �� *Side1+  51      $ Side2��61    6@   �� *Side2+  52      $ Side3��61    6@   �� *Side3+  53      $ Length��61    6A   �� *Length+  54      $ Width��61    6@   �� *Width+  55      $ Radius��61    6A   �� *Radius+  56      $ 
AreaResult��61    6E   �� *
AreaResult+58      59      � 5;      $��3��6   $��20q�6    .+�5<      �� -   5         ��Name$ comboBox��5<      $
��Left=�6-   $	��Top=�6H   $	��200��6`   $��40��6l   ��6x   �� *
ShapeTypes+6�   �� 5=      $��Search��6   $
��Left=�6)   $��	220 0 0 0q�6D   $��Center=�6W   $ 0.776,-0.287&�6r   $��40��6�   $	��100��6�   $
��Bold"�6�   
�������6�   �� 5>      -   5         ��Name$ BtnBackToMain��5>      $��Main Window��60   $��Right=�6F   $��Center=�6b   $	��104��6}   $��35��6�   
���   ����	#FFE2C5C5��5?      �� 5@       �� 
StartPoint$	 0,0&�6.    �� EndPoint$	 1,2&�6?   .��5A      �  � Color$ 	#FFE0E54C��6+    � Offset$ 0Q�6=   � 5B      $ 	#FFE0E51C��6+   $ 1Q�6=   5C       � 	Resources 5E       �� 
TargetType �� Property �� Value��%^   '��       �� 5F      " ��6    .�5G      ��  �@��CornerRadius$ 7��6=   5H      5I      5J      5K      5M      5N      5O      
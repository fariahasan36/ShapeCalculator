   M S B A M L   `   `   `  ����M  IShapeCalculatorGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ShapeCalculatorGUIShapeCalculatorGUI  5   	       ShapeCalculatorGUI.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ShapeCalculatorGUI     5   	     � Title$  Login��5   	   $	��450��6   $	��800��6$    � 
ResizeMode$ NoResize=�5	   	   
������ .��5   
   �� ���#555588 �� CornerRadius$ 10��5   	   ._�5   
   �  � RowDefinitions 5      �� 5      $��80 �6    6.   �� 5      $	��180 �6    6/   �� 5      $��80 �6    6.   .+�5      �� $��0��6   $��
Login Here��6%   $��Center=�67   $��Center=�6T   $��22(�6o   
�������$��0 20 0 0q�6�   �� 5      $��1��6   $��Center=�6&   $	��Top=�6C   .+�5      �� $��	User Name��6   $��0��6,   
�������$��0q�6M   6Z   �� 5      ���#efefef
���   �$ 10��6B   $��0 10 0 0q�6T   ._�5      �� -   5         ��Name$ TxtUserName��5      $��Center=�63    �� TextWrapping$
 Wrap=�6Q   $��Center=�6e   $��1q�6�   $��0q�6�   $��Center=�6�   $��5q�6�   
���   �$	��200��6�   $��40��6�   
������ 6�   5      �� 5      $��Password��6   
�������$��1��6@   $��0q�6M   6Z   �� 5      ���#efefef
���   �$ 10��6B   $��0 10 0 0q�6T   ._�5      G� -   5         G�Name$ TxtPassword��5   "   $��Center=�67   $��Center=�6T   $��1q�6o   $��0q�6z   $��Center=�6�   $��5q�6�   
���   �$	��200��6�   $��40��6�   
������ 6�   5      5       �� 5"      -   5         ��Name$ BtnLogin��5"   &   $��3��6   $��Login��68   $��Center=�6H   $��Center=�6e   $	��104��6�   $��35��6�   
�������
�������$
��Bold"�6�   $��14(�6�   6  5'      5(      5)      
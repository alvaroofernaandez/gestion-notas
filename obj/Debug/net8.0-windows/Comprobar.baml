   M S B A M L   `   `   `  ����C  ?Ficheros, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:FicherosFicheros  5   	       Ficheros.Comprobar   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Ficheros     5   	     � Title$  	Comprobar��5   	   $	��450��6   $	��800��6(   .��5	      � ���	#FF362F2F � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��3* �6   .+�5   
   �� -   5         ��Name$ txlTitulo_Copiar1��5      $��Visionado archivos��6+   $��Center=�6H   $��Center=�6e   $��24(�6�   $��Segoe UI Black)�6�   ���	#00000000
�������$��40��6�   � 5   
   $��1��6   $��0��6   $��Stretch=�6,    5      �� 5      $��* �6    �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      �� $��1��6   $��Center=�6&   $��Stretch=�6A   $
��20,0q�6_   .+�5      �� -   5         ��Name$ btnVisionar1��5      $��Metodo 1��6/    � Cursor$
 Hand��6B   $��Cascadia Code SemiBold)�6P   $��20(�6�   $��Stretch=�6�   $	��0,5q�6�   ���	#FF615454
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5       5"      �� 5#      -   5        $ btnVisionar2��5#      $��Metodo 2��6/   $
 Hand��6B   $��Cascadia Code SemiBold)�6P   $��20(�6�   $��Stretch=�6�   $	��0,5q�6�   ���	#FF615454
������� 5$        5%      5'      �� 5(      -   5        $ btnVisionar3��5(      $��Metodo 3��6/   $
 Hand��6B   $��Cascadia Code SemiBold)�6P   $��20(�6�   $��Stretch=�6�   $	��0,5q�6�   ���	#FF615454
������� 5)        5*      5,      �� 5-      -   5        $ btnVisionar4��5-      $��Metodo 4��6/   $
 Hand��6B   $��Cascadia Code SemiBold)�6P   $��20(�6�   $��Stretch=�6�   $	��0,5q�6�   ���	#FF615454
������� 5.        5/      51      �� 52      -   5        $ btnBorrarContenido��52      $��Resetear��65   $
 Hand��6H   $��Cascadia Code SemiBold)�6V   $��20(�6�   
����������	#FFE3A00E$��Stretch=�6�   $	��0,5q�6�    53        54      56      �� 57      -   5        $ 	btnCerrar��57      $��Cerrar��6,   $
 Hand��6=   $��Cascadia Code SemiBold)�6K   $��20(�6�   ���	#FFA90000
�������$��Stretch=�6�   $	��0,5q�6�    58        59      5;      5<      5=      � 5>   
   $��1��6   $��1��6   $��20q�6,   ���	#FF201E1E 5?      �� 5@      $
��Auto �6    �� 5A      $��* �6    .+�5C      �� -   5        $ lblInput��5C      $&�� Introduce el nombre del archivo:��6&   
�������$��Cascadia Code)�6d   $��16(�6   $��
0,-24,0,44q�6�   $
��Left=�6�   �� 5D      -	   5         ��Name$ txbNombreArchivo��5D      $��0��60    �� TextWrapping$
 Wrap=�6=   $��Cascadia Code)�6Q   $��16(�6l   $��
10,10,10,5q�6z   �� 5E      -
   5        $ txbContenidoVisionado��5E      $��1��65   $
 Wrap=�6B   $��Cascadia Code)�6V   $��20(�6q   "	 �� VerticalScrollBarVisibility$
	 Auto=�6   
 �� AcceptsReturn$

 True��6�   $��
10,5,10,20q�6�   5F      5G      5H      
   M S B A M L   `   `   `  ����C  ?Ficheros, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:FicherosFicheros  5   	       Ficheros.Crear   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Ficheros     5   	     � Title$  Crear��5   	   $	��450��6   $	��800��6$   .��5	      � ���	#FF362F2F.+�5
   
   �� -   5         ��Name$ txbNombreFichero��5
      $��Center=�6,   $��	0,113,0,0q�6I    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $	��294��6�   $��18(�6�   �� 5   
   -   5        $ 
txbContent��5      $��Center=�6&   $��	0,189,0,0q�6C   $
 Wrap=�6V   $	��Top=�6j   $	��294��6�   $��98��6�   $��Cascadia Mono SemiBold)�6�   $��18(�6�   �� 5   
   -   5         ��Name$ btnCrearArchivo��5      $��Crear��6*   $��Center=�6:   $��	0,312,0,0q�6W   $	��Top=�6j    � Cursor$
 Hand��6�   $��30��6�   $	��135��6�   $��Cascadia Mono SemiBold)�6�   $��18(�6�   ���	#FF615454
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5   
   -   5         ��Name$ 	LblInput2��5      $��Introduce el contenido:��6#   $��Center=�6E   $��	0,154,0,0q�6b   $	��Top=�6u   
�������$��29��6�   $	��294��6�   $��Cascadia Mono SemiBold)�6�   $��18(�6�    J� RenderTransformOrigin$ 0.434,0.567&�6�   $
��Bold"�6  z�5      V� 5      .~�5      �� �� 5       �� AngleX$ -2.189Q�6$   �� 5      T� 5      	 T� X$	 0.378Q�6)   5      5      �� 5   
   -   5        $ LblInput2_Copiar��5      $��Introduce el titulo:��6*   $��Center=�6I   $��0,82,0,0q�6f   $	��Top=�6x   
�������$��29��6�   $	��294��6�   $��Cascadia Mono SemiBold)�6�   $��18(�6�   $ 0.434,0.567&�6�   $
��Bold"�6  z�5      V� 5      .~�5      �� �� 5      $ -2.189Q�6$   �� 5       T� 5!      $	 0.378Q�6)   5"      5$      �� 5%   
   -   5        $ 	txlTitulo��5%      $��Creación archivos��6#   $��Center=�6?   $	��Top=�6\   $��24(�6t   $��Segoe UI Black)�6�   ���	#00000000
�������$��0,16,0,0q�6�   �� 5&   
   -   5        $ btnCerrarVentana��5&      $��
Cerrar (X)��6+   $��Center=�6@   $��	0,347,0,0q�6]   $	��Top=�6p   $��Cascadia Mono SemiBold)�6�   $��18(�6�   $	��135��6�   $��35��6�   ���	#FFC50000
������� 5'        5(      5*      5,      5-      
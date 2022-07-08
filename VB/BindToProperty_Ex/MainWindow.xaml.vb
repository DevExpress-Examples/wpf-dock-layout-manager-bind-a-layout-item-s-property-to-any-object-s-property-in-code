Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports DevExpress.Xpf.Docking

Namespace BindToProperty_Ex

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Call BindingOperations.SetBinding(Me.myLabel, BaseLayoutItem.CaptionProperty, New Binding("Text") With {.Source = Me.myTextEdit})
            Me.myTextEdit.Focus()
        End Sub
    End Class
End Namespace

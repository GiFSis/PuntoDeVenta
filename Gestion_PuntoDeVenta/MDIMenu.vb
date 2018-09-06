Imports System.Windows.Forms

Public Class MDIMenu

    Private Sub MDIMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Gestión Comercial - GiF Sys - " & Date.Today

        Me.ToolStripLabelUsuario.Text = usuarioGlobal
        If usuarioGlobal = "Admin" Then
        End If
        FrmVentas.MdiParent = Me
        FrmVentas.Show()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).WindowState = FormWindowState.Normal
        Next
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).WindowState = FormWindowState.Minimized
        Next
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub ConfiguraciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraciónToolStripMenuItem.Click
        FrmMisDatos.MdiParent = Me
        FrmMisDatos.Show()
    End Sub

    Private Sub ArticulosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticulosToolStripMenuItem1.Click
        FrmArticulos.MdiParent = Me
        FrmArticulos.Show()
        FrmArticulos.BtnSeleccionar.Visible = True
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        frmClientes.MdiParent = Me
        frmClientes.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        frmProveedores.MdiParent = Me
        frmProveedores.Show()
        frmProveedores.BtnCopiar.Visible = True
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        FrmAbout.MdiParent = Me
        FrmAbout.Show()
    End Sub

    Private Sub BackUpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackUpToolStripMenuItem1.Click
        FrmBackUp.MdiParent = Me
        FrmBackUp.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem1.Click
        LoginFormUsuarios.MdiParent = Me
        LoginFormUsuarios.Show()
    End Sub

    Private Sub PresupuestoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresupuestoToolStripMenuItem1.Click
        FrmBusquedaPresupuesto.MdiParent = Me
        FrmBusquedaPresupuesto.Show()
    End Sub

    Private Sub PresupuestoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmPresupuestos.MdiParent = Me
        FrmPresupuestos.Show()
    End Sub

    Private Sub VentasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem1.Click
        FrmBusquedaVenta.MdiParent = Me
        FrmBusquedaVenta.Show()
    End Sub

    Private Sub VentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentaToolStripMenuItem.Click
        FrmVentas.MdiParent = Me
        FrmVentas.Show()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasToolStripMenuItem.Click
        frmCompras.MdiParent = Me
        frmCompras.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim resultado As DialogResult = MessageBox.Show("Está seguro de salir?",
                                            "Atención", MessageBoxButtons.YesNo)
        If resultado = Windows.Forms.DialogResult.Yes Then
            'Deja el formulario activo 
            FrmLogin.Show()
            FrmLogin.UsernameTextBox.Focus()
            Me.Close()
        End If
    End Sub

    Private Sub CajaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajaToolStripMenuItem1.Click
        frmCaja.MdiParent = Me
        frmCaja.Show()
    End Sub

    'Informes
    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click
        FrmInformeStock.MdiParent = Me
        FrmInformeStock.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem1.Click
        FrmInformeClientes.MdiParent = Me
        FrmInformeClientes.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        FrmInformeProveedores.MdiParent = Me
        FrmInformeProveedores.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem.Click
        FrmDesdeHasta.MdiParent = Me
        FrmDesdeHasta.Show()
        FrmDesdeHasta.BtnInfVenta.Visible = True
    End Sub

    Private Sub MovimientosDeCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosDeCajaToolStripMenuItem.Click
        FrmDesdeHasta.MdiParent = Me
        FrmDesdeHasta.Show()
        FrmDesdeHasta.BtnInfCaja.Visible = True
    End Sub

    'HotKeys a formularios
    Const VK_CTR = &H11 'IZDO
    Const VK_MENU = &H12   'Alt 
    Const VK_A = &H41
    Const VK_B = &H42
    Const VK_C = &H43
    Const VK_D = &H44
    Const VK_E = &H45
    Const VK_F = &H46
    Const VK_G = &H47
    Const VK_H = &H48
    Const VK_I = &H49
    Const VK_J = &H4A
    Const VK_K = &H4B
    Const VK_L = &H4C
    Const VK_M = &H4D
    Const VK_N = &H4E
    Const VK_O = &H4F
    Const VK_P = &H50
    Const VK_Q = &H51
    Const VK_R = &H52
    Const VK_S = &H53
    Const VK_T = &H54
    Const VK_U = &H55
    Const VK_V = &H56
    Const VK_W = &H57
    Const VK_X = &H58
    Const VK_Y = &H59
    Const VK_Z = &H5A

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If (GetAsyncKeyState(VK_CTR)) And (GetAsyncKeyState(VK_V)) Then
            FrmVentas.MdiParent = Me
            FrmVentas.Show()
            'ElseIf (GetAsyncKeyState(VK_CTR)) And (GetAsyncKeyState(VK_P)) Then
            '    FrmPresupuestos.MdiParent = Me
            '    FrmPresupuestos.Show()
        ElseIf (GetAsyncKeyState(VK_CTR)) And (GetAsyncKeyState(VK_C)) Then
            frmCompras.MdiParent = Me
            frmCompras.Show()
        ElseIf (GetAsyncKeyState(VK_CTR)) And (GetAsyncKeyState(VK_A)) Then
            frmCaja.MdiParent = Me
            frmCaja.Show()
        End If
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Dim d
        d = Shell("Calc.exe")
    End Sub

    Private Sub ActualizaPreciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizaPreciosToolStripMenuItem.Click
        FrmActualizaPrecio.MdiParent = Me
        FrmActualizaPrecio.Show()
    End Sub

    Private Sub MarcaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcaToolStripMenuItem.Click
        FrmMarca.MdiParent = Me
        FrmMarca.Show()
    End Sub
End Class

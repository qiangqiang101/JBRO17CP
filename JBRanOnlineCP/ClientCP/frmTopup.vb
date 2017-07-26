Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmTopup

    Dim xConn As sqlConn
    Dim r As Random = New Random
    Dim nl As String = Environment.NewLine
    Dim line1 As String = "本服秉着公平公正的原则向广大玩家开放赞助装备，以维持伺服器正常运行，所有贩售之装备在游戏中均能获得，视个人能力赞助，觉得贵觉得负担不起不要赞助就好，本服不勉强任何人赞助，就算您完全没赞助本服，也一样能在本服畅玩游戏，也不会因为有赞助或 没赞助会有差别待遇，所有会员或非会员我们都将一视同仁。"
    Dim line2 As String = "1. 玩家必须出于自愿赞助以及维持伺服器运行。
2. 请玩家自行保管好自己的账号及密码，珍惜自己的装备，不要互相转借。
3. 会员装备如出现不慎强化爆装或贩售商店由玩家自行负责。
4. 会员装备玩家若转借发生纠纷或者因转借而遗失，本服不介入处理。
5. 所购买之会员装备不得转售，如有转售情形立即对买卖双方停权并没收会员装备。
6. 本服不帮忙任何玩家调趴服务。
7. 所有会员装备一旦发到玩家手上正常绝对不会丢失，一旦发现丢失既不负责。
8. 游戏内的任何物品，在白名或红名的情况下，死亡都会有可能掉落。
9. 任何已购买的物品，买了以后不能退货，也不能换其他等值的赞助物品，一旦买错自行负责。"
    Dim line3 As String = "赞助方式:
        1马币=10积分
        1新币=31积分"

    Private Sub NumbericKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Amount.KeyPress
        Dim ValidChars As String = "0123456789."
        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub frmTopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_Bank.SelectedIndex = 0
        cmb_Channel.SelectedIndex = 0
        cmb_Dollar.SelectedIndex = 0
        lbl_CODE.Text = r.Next(1, 9999)
        lbl_Note.Text = String.Format("{1}{0}{0}{2}{0}{0}{3}", nl, line1, line2, line3)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrEmpty(txt_Amount.Text) Then
            MsgBox("当前操作有误！", MsgBoxStyle.Critical, "错误")
            txt_Amount.Focus()
        ElseIf txt_Amount.Text = "0" Then
            MsgBox("当前操作有误！", MsgBoxStyle.Critical, "错误")
            txt_Amount.Focus()
        ElseIf txt_CPVerification.Text <> lbl_CODE.Text Then
            MsgBox("输入的验证码不正确，请重新输入。", MsgBoxStyle.Critical, "错误")
            txt_CPVerification.Clear()
            txt_CPVerification.Focus()
        Else
            If txt_RefNo.Text = "" Then txt_RefNo.Text = "-"
            Try
                xConn = New sqlConn()
                xConn.connectUser("Insert Into CPTransaction (UserName, Bank, Amount, Currency, Channel, Status, RefSEQNo) " _
                    & "VALUES (" _
                                & "'" & txt_TUUserName.Text & "', " _
                                & "'" & cmb_Bank.SelectedItem & "', " _
                                & "'" & txt_Amount.Text & "', " _
                                & "'" & cmb_Dollar.SelectedItem & "', " _
                                & "'" & cmb_Channel.SelectedItem & "', " _
                                & "'" & "New" & "', " _
                                & "'" & txt_RefNo.Text & "');")
                xConn.UserSQLComm.Connection = xConn.UserSQLConn
                xConn.UserSQLComm.ExecuteNonQuery()
                xConn.UserSQLConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "错误")
            Finally
                Try
                    Dim newForm As frmTransaction = New frmTransaction
                    frmCP.cpTab.TabPages.Add(newForm)
                Catch ex As Exception
                End Try
                lbl_CODE.Text = r.Next(1, 9999)
                Me.Close()
            End Try
        End If
    End Sub
End Class
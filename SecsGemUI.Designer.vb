<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecGemUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RunStatus = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Start = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProcessStatusChanged = New System.Windows.Forms.Button()
        Me.StatusChanged = New System.Windows.Forms.Button()
        Me.RecipeChanged = New System.Windows.Forms.Button()
        Me.RecipeListChanged = New System.Windows.Forms.Button()
        Me.LogIn = New System.Windows.Forms.Button()
        Me.ShutDown = New System.Windows.Forms.Button()
        Me.ControlStateChanged = New System.Windows.Forms.Button()
        Me.ProcessCompleted = New System.Windows.Forms.Button()
        Me.OverTemp = New System.Windows.Forms.CheckBox()
        Me.FlowRateLowCB = New System.Windows.Forms.CheckBox()
        Me.FlowRateHighCB = New System.Windows.Forms.CheckBox()
        Me.EStopCB = New System.Windows.Forms.CheckBox()
        Me.IntenralCommErrorCB = New System.Windows.Forms.CheckBox()
        Me.OtherErrorCB = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HostCmdReceived = New System.Windows.Forms.Label()
        Me.HSMSComm = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RunStatus
        '
        Me.RunStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunStatus.Location = New System.Drawing.Point(361, 20)
        Me.RunStatus.Name = "RunStatus"
        Me.RunStatus.Size = New System.Drawing.Size(312, 23)
        Me.RunStatus.TabIndex = 0
        Me.RunStatus.Text = "Not Running"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.Location = New System.Drawing.Point(232, 20)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(126, 16)
        Me.StatusLabel.TabIndex = 1
        Me.StatusLabel.Text = "Auto Status Update:"
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(71, 17)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(139, 23)
        Me.Start.TabIndex = 2
        Me.Start.Text = "Run Auto Update"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Alarms:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Events:"
        '
        'ProcessStatusChanged
        '
        Me.ProcessStatusChanged.Location = New System.Drawing.Point(232, 62)
        Me.ProcessStatusChanged.Name = "ProcessStatusChanged"
        Me.ProcessStatusChanged.Size = New System.Drawing.Size(140, 23)
        Me.ProcessStatusChanged.TabIndex = 11
        Me.ProcessStatusChanged.Text = "Process Status Changed"
        Me.ProcessStatusChanged.UseVisualStyleBackColor = True
        '
        'StatusChanged
        '
        Me.StatusChanged.Location = New System.Drawing.Point(71, 62)
        Me.StatusChanged.Name = "StatusChanged"
        Me.StatusChanged.Size = New System.Drawing.Size(140, 23)
        Me.StatusChanged.TabIndex = 12
        Me.StatusChanged.Text = "Status Changed"
        Me.StatusChanged.UseVisualStyleBackColor = True
        '
        'RecipeChanged
        '
        Me.RecipeChanged.Location = New System.Drawing.Point(559, 59)
        Me.RecipeChanged.Name = "RecipeChanged"
        Me.RecipeChanged.Size = New System.Drawing.Size(140, 23)
        Me.RecipeChanged.TabIndex = 13
        Me.RecipeChanged.Text = "Recipe Changed"
        Me.RecipeChanged.UseVisualStyleBackColor = True
        '
        'RecipeListChanged
        '
        Me.RecipeListChanged.Location = New System.Drawing.Point(72, 99)
        Me.RecipeListChanged.Name = "RecipeListChanged"
        Me.RecipeListChanged.Size = New System.Drawing.Size(140, 23)
        Me.RecipeListChanged.TabIndex = 14
        Me.RecipeListChanged.Text = "Recipe List Changed"
        Me.RecipeListChanged.UseVisualStyleBackColor = True
        '
        'LogIn
        '
        Me.LogIn.Location = New System.Drawing.Point(398, 99)
        Me.LogIn.Name = "LogIn"
        Me.LogIn.Size = New System.Drawing.Size(140, 23)
        Me.LogIn.TabIndex = 15
        Me.LogIn.Text = "Log In"
        Me.LogIn.UseVisualStyleBackColor = True
        '
        'ShutDown
        '
        Me.ShutDown.Location = New System.Drawing.Point(559, 102)
        Me.ShutDown.Name = "ShutDown"
        Me.ShutDown.Size = New System.Drawing.Size(140, 23)
        Me.ShutDown.TabIndex = 16
        Me.ShutDown.Text = "Shut Down"
        Me.ShutDown.UseVisualStyleBackColor = True
        '
        'ControlStateChanged
        '
        Me.ControlStateChanged.Location = New System.Drawing.Point(398, 60)
        Me.ControlStateChanged.Name = "ControlStateChanged"
        Me.ControlStateChanged.Size = New System.Drawing.Size(140, 23)
        Me.ControlStateChanged.TabIndex = 17
        Me.ControlStateChanged.Text = "Control State Changed"
        Me.ControlStateChanged.UseVisualStyleBackColor = True
        '
        'ProcessCompleted
        '
        Me.ProcessCompleted.Location = New System.Drawing.Point(232, 99)
        Me.ProcessCompleted.Name = "ProcessCompleted"
        Me.ProcessCompleted.Size = New System.Drawing.Size(140, 23)
        Me.ProcessCompleted.TabIndex = 18
        Me.ProcessCompleted.Text = "Process Completed"
        Me.ProcessCompleted.UseVisualStyleBackColor = True
        '
        'OverTemp
        '
        Me.OverTemp.AutoSize = True
        Me.OverTemp.Location = New System.Drawing.Point(71, 142)
        Me.OverTemp.Name = "OverTemp"
        Me.OverTemp.Size = New System.Drawing.Size(79, 17)
        Me.OverTemp.TabIndex = 20
        Me.OverTemp.Text = "Over Temp"
        Me.OverTemp.UseVisualStyleBackColor = True
        '
        'FlowRateLowCB
        '
        Me.FlowRateLowCB.AutoSize = True
        Me.FlowRateLowCB.Location = New System.Drawing.Point(156, 142)
        Me.FlowRateLowCB.Name = "FlowRateLowCB"
        Me.FlowRateLowCB.Size = New System.Drawing.Size(97, 17)
        Me.FlowRateLowCB.TabIndex = 21
        Me.FlowRateLowCB.Text = "Flow Rate Low"
        Me.FlowRateLowCB.UseVisualStyleBackColor = True
        '
        'FlowRateHighCB
        '
        Me.FlowRateHighCB.AutoSize = True
        Me.FlowRateHighCB.Location = New System.Drawing.Point(259, 142)
        Me.FlowRateHighCB.Name = "FlowRateHighCB"
        Me.FlowRateHighCB.Size = New System.Drawing.Size(99, 17)
        Me.FlowRateHighCB.TabIndex = 22
        Me.FlowRateHighCB.Text = "Flow Rate High"
        Me.FlowRateHighCB.UseVisualStyleBackColor = True
        '
        'EStopCB
        '
        Me.EStopCB.AutoSize = True
        Me.EStopCB.Location = New System.Drawing.Point(364, 142)
        Me.EStopCB.Name = "EStopCB"
        Me.EStopCB.Size = New System.Drawing.Size(58, 17)
        Me.EStopCB.TabIndex = 23
        Me.EStopCB.Text = "E-Stop"
        Me.EStopCB.UseVisualStyleBackColor = True
        '
        'IntenralCommErrorCB
        '
        Me.IntenralCommErrorCB.AutoSize = True
        Me.IntenralCommErrorCB.Location = New System.Drawing.Point(428, 142)
        Me.IntenralCommErrorCB.Name = "IntenralCommErrorCB"
        Me.IntenralCommErrorCB.Size = New System.Drawing.Size(123, 17)
        Me.IntenralCommErrorCB.TabIndex = 24
        Me.IntenralCommErrorCB.Text = "Internal Comms Error"
        Me.IntenralCommErrorCB.UseVisualStyleBackColor = True
        '
        'OtherErrorCB
        '
        Me.OtherErrorCB.AutoSize = True
        Me.OtherErrorCB.Location = New System.Drawing.Point(557, 142)
        Me.OtherErrorCB.Name = "OtherErrorCB"
        Me.OtherErrorCB.Size = New System.Drawing.Size(77, 17)
        Me.OtherErrorCB.TabIndex = 25
        Me.OtherErrorCB.Text = "Other Error"
        Me.OtherErrorCB.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 28
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HostCmdReceived)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 65)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Host Remote Commands"
        '
        'HostCmdReceived
        '
        Me.HostCmdReceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HostCmdReceived.Location = New System.Drawing.Point(20, 28)
        Me.HostCmdReceived.Name = "HostCmdReceived"
        Me.HostCmdReceived.Size = New System.Drawing.Size(437, 23)
        Me.HostCmdReceived.TabIndex = 28
        '
        'HSMSComm
        '
        Me.HSMSComm.Location = New System.Drawing.Point(19, 271)
        Me.HSMSComm.Name = "HSMSComm"
        Me.HSMSComm.Size = New System.Drawing.Size(153, 23)
        Me.HSMSComm.TabIndex = 32
        Me.HSMSComm.Text = "HSMS Comm Settings"
        Me.HSMSComm.UseVisualStyleBackColor = True
        '
        'SecGemUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 397)
        Me.Controls.Add(Me.HSMSComm)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OtherErrorCB)
        Me.Controls.Add(Me.IntenralCommErrorCB)
        Me.Controls.Add(Me.EStopCB)
        Me.Controls.Add(Me.FlowRateHighCB)
        Me.Controls.Add(Me.FlowRateLowCB)
        Me.Controls.Add(Me.OverTemp)
        Me.Controls.Add(Me.ProcessCompleted)
        Me.Controls.Add(Me.ControlStateChanged)
        Me.Controls.Add(Me.ShutDown)
        Me.Controls.Add(Me.LogIn)
        Me.Controls.Add(Me.RecipeListChanged)
        Me.Controls.Add(Me.RecipeChanged)
        Me.Controls.Add(Me.StatusChanged)
        Me.Controls.Add(Me.ProcessStatusChanged)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.RunStatus)
        Me.Name = "SecGemUI"
        Me.Text = "SecGem UI"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RunStatus As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents Start As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProcessStatusChanged As Button
    Friend WithEvents StatusChanged As Button
    Friend WithEvents RecipeChanged As Button
    Friend WithEvents RecipeListChanged As Button
    Friend WithEvents LogIn As Button
    Friend WithEvents ShutDown As Button
    Friend WithEvents ControlStateChanged As Button
    Friend WithEvents ProcessCompleted As Button
    Friend WithEvents OverTemp As CheckBox
    Friend WithEvents FlowRateLowCB As CheckBox
    Friend WithEvents FlowRateHighCB As CheckBox
    Friend WithEvents EStopCB As CheckBox
    Friend WithEvents IntenralCommErrorCB As CheckBox
    Friend WithEvents OtherErrorCB As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents HostCmdReceived As Label
    Friend WithEvents HSMSComm As Button
End Class

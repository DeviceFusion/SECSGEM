
Imports System.Threading

Public Class SecGemUI

    'Private SecsGemUpdate_thread As Thread
    Private Shared run_flag As Boolean = False
    Private Msgtxt As String
    Private Delegate Sub SetTextCallback(msgtext As String)

    ' Status Monitor Object
    Dim objMonitorStatus As New clsMonitorStatus
    ' SECS/GEM Interface Object
    Dim objSecsGemInterface As New clsBurlyticSecsGemInterface(objMonitorStatus)





    Private Sub SecGemUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Start the SECS/GEM Interface Update Thread
        objSecsGemInterface.StartInterfaceUpdates
        'SecsGemUpdate_thread = New Thread(AddressOf objSECSGEMInterface.trdBurlyticDataUpdater)
        'SecsGemUpdate_thread.IsBackground = True
        'SecsGemUpdate_thread.Start()

        ' add event handlers for GEM Remote command received events
        AddHandler objMonitorStatus.eGEMRemoteCommandInhibitReceived, AddressOf ReceivedGEMRemoteInhibitCommandHandler
        AddHandler objMonitorStatus.eGEMRemoteCommandReleaseInhibitReceived, AddressOf ReceivedGEMRemoteReleaseInhibitCommandHandler
        ' add call back for the GEM Terminal Message handling and display
        AddHandler objMonitorStatus.eGEMTerminalMessageHandler, AddressOf GEMTerminalMessageHandler

    End Sub





    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        run_flag = Not run_flag
        Debug.Print("runflag:" + run_flag.ToString)
        If run_flag = True Then
            RunStatus.Text = "Auto Status Update - Running"
        Else
            RunStatus.Text = "Auto Status Update - Not Running"
        End If
        objMonitorStatus.SetAutoStatusReportFlag(run_flag)
    End Sub

    Public Sub SetText(msgtext As String)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If (RunStatus.InvokeRequired) Then
            'Invoke(SetTextCallback(msgtext))
            Invoke(New SetTextCallback(AddressOf SetText), msgtext)

        Else

            RunStatus.Text = msgtext
            RunStatus.Update()
        End If
    End Sub

    Public Function Get_Runflag() As Boolean
        Return (run_flag)
    End Function

    ' =========== EVENTS ========
    Private Sub ProcessStatusChanged_Click(sender As Object, e As EventArgs) Handles ProcessStatusChanged.Click
        objMonitorStatus.RaiseProcessStatusChangedEvent()
    End Sub

    Private Sub StatusChanged_Click(sender As Object, e As EventArgs) Handles StatusChanged.Click
        objMonitorStatus.RaiseStatusChangedEvent()
    End Sub

    Private Sub RecipeChanged_Click(sender As Object, e As EventArgs) Handles RecipeChanged.Click
        objMonitorStatus.RaiseRecipeChangedEvent()
    End Sub

    Private Sub RecipeListChanged_Click(sender As Object, e As EventArgs) Handles RecipeListChanged.Click
        objMonitorStatus.RaiseRecipeListChangedEvent()
    End Sub

    Private Sub LogIn_Click(sender As Object, e As EventArgs) Handles LogIn.Click
        objMonitorStatus.RaiseLogInEvent()
    End Sub

    Private Sub ShutDown_Click(sender As Object, e As EventArgs) Handles ShutDown.Click
        objMonitorStatus.RaiseShutDownEvent()
    End Sub

    Private Sub ControlStateChanged_Click(sender As Object, e As EventArgs) Handles ControlStateChanged.Click
        objMonitorStatus.RaiseControlStateChangedEvent()
    End Sub

    Private Sub ProcessCompleted_Click(sender As Object, e As EventArgs) Handles ProcessCompleted.Click
        objMonitorStatus.RaiseProcessCompletedEvent()
    End Sub

    ' =========== ALARMS ========
    Private Sub OverTemp_CheckedChanged(sender As Object, e As EventArgs) Handles OverTemp.CheckedChanged
        If OverTemp.Checked Then
            objMonitorStatus.RaiseOverTempAlarm()
        Else
            objMonitorStatus.RaiseClearOverTempAlarm()
        End If

    End Sub

    Private Sub FlowRateLowCB_CheckedChanged(sender As Object, e As EventArgs) Handles FlowRateLowCB.CheckedChanged
        If FlowRateLowCB.Checked Then
            objMonitorStatus.RaiseFlowRateLowAlarm()
        Else
            objMonitorStatus.RaiseClearFlowRateLowAlarm()
        End If

    End Sub

    Private Sub FlowRateHighCB_CheckedChanged(sender As Object, e As EventArgs) Handles FlowRateHighCB.CheckedChanged
        If FlowRateHighCB.Checked Then
            objMonitorStatus.RaiseFlowRateHighAlarm()
        Else
            objMonitorStatus.RaiseClearFlowRateHighAlarm()
        End If

    End Sub

    Private Sub EStopCB_CheckedChanged(sender As Object, e As EventArgs) Handles EStopCB.CheckedChanged
        If EStopCB.Checked Then
            objMonitorStatus.RaiseEStopAlarm()
        Else
            objMonitorStatus.RaiseClearEStopAlarm()
        End If

    End Sub

    Private Sub IntenralCommErrorCB_CheckedChanged(sender As Object, e As EventArgs) Handles IntenralCommErrorCB.CheckedChanged
        If IntenralCommErrorCB.Checked Then
            objMonitorStatus.RaiseICommErrorAlarm()
        Else
            objMonitorStatus.RaiseClearICommErrorAlarm()
        End If

    End Sub

    Private Sub OtherErrorCB_CheckedChanged(sender As Object, e As EventArgs) Handles OtherErrorCB.CheckedChanged
        If OtherErrorCB.Checked Then
            objMonitorStatus.RaiseOtherErrorAlarm()
        Else
            objMonitorStatus.RaiseClearOtherErrorAlarm()

        End If

    End Sub

    Private Sub RunStatus_Click(sender As Object, e As EventArgs) Handles RunStatus.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub


    ' ==== functions to test GEMS remote command handlng =========
    ' in real operation the like the ones below.
    ' To  test this wll send the command direclty by calling the 
    ' objSecsGemInterface.CimetrixAPI_RemoteCommandHandler directly
    ' that will trigger the  objMonitorStatus.GEMRemoteCommandInhibitReceived event 
    ' which in turn will call back to the the handler below
    'Private Sub Inhibit_Click(sender As Object, e As EventArgs) Handles Inhibit.Click
    'Dim argnames() As String = {"Inhbit"}
    'Dim argvals() As String = {"Inhbit"}
    'Dim commandResult As EMSERVICELib.CommandResults
    'Dim RCargs As CCimetrixAPI.RemoteCommandArgs = New CCimetrixAPI.RemoteCommandArgs(0, clsBurlyticGEMDefinitions.m_GEMREMOTECMD_Inhibit, argnames, argvals, commandResult)
    '    objSecsGemInterface.CimetrixAPI_RemoteCommandHandler(sender, RCargs)
    'End Sub

    ' To test Send the ReleaseInhibit command direclty thorugh the Cimetrix Remote Command Handler
    ' that will trigger the  objMonitorStatus.GEMRemoteCommandReleaseInhibitReceived event 
    ' which in turn will call back to the the handler below
    'Private Sub ReleaseInhibit_Click(sender As Object, e As EventArgs) Handles ReleaseInhibit.Click
    'Dim argnames() As String = {"Inhbit"}
    'Dim argvals() As String = {"Inhbit"}
    'Dim commandResult As EMSERVICELib.CommandResults
    'Dim RCargs As CCimetrixAPI.RemoteCommandArgs = New CCimetrixAPI.RemoteCommandArgs(0, clsBurlyticGEMDefinitions.m_GEMREMOTECMD_ReleaseInhibit, argnames, argvals, commandResult)
    '     objSecsGemInterface.CimetrixAPI_RemoteCommandHandler(sender, RCargs)
    'End Sub


    '========= GEM Remote Command Handlers ========
    ' Received remote ommands are sent from the EMServce via a callback To 
    ' objSecsGemInterface.CimetrixAPI_RemoteCommandHandler which parses the command and triggers the
    ' appropriate objectMonitor event, that event is then caught by these handlers 
    Sub ReceivedGEMRemoteInhibitCommandHandler()
        'clsBurlyticGEMDefinitions.BurlyticProcessState.
        ' Handle the event.
        Debug.Print("***** ReceivedGEMRemoteInhibitCommandHandler caught event.")
        SetRemoteCmdText("Received Remote Command Inhbit")
    End Sub
    Sub ReceivedGEMRemoteReleaseInhibitCommandHandler()
        'clsBurlyticGEMDefinitions.BurlyticProcessState.
        ' Handle the event.
        Debug.Print("***** ReceivedGEMRemoteInhibitCommandHandler caught event.")

        SetRemoteCmdText("Received Remote Command Release Inhbit")
    End Sub
    ' ========= Enable Remote Command sentby another thread to be displayed on the main GUI threaad =======
    ' delegate so HostMessageReceived control can be updated by another abouve handlers that
    ' are called form another thread
    Private Delegate Sub SetRemoteCmdOnMainGUI(msgtextas As String)
    Public Sub SetRemoteCmdText(msgtext As String)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If (RunStatus.InvokeRequired) Then
            'Invoke(SetTextCallback(msgtext))
            Invoke(New SetRemoteCmdOnMainGUI(AddressOf SetRemoteCmdText), msgtext)

        Else

            HostCmdReceived.Text = msgtext
            HostCmdReceived.Update()
        End If
    End Sub

    Sub GEMTerminalMessageHandler(ByVal sender As Object, ByVal e As clsMonitorStatus.GEMTerminalMessageArgs)
        DisplayTerminalMessage(e.TextMessage)
    End Sub

    ' ========= Enable Terminal Message sent by another thread to be displayed on the main GUI threaad =======
    Private Delegate Sub DisplayTerminalMessageOnMainGUI(msgtextas As String)
    Public Sub DisplayTerminalMessage(msgtext As String)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If (RunStatus.InvokeRequired) Then
            'Invoke(SetTextCallback(msgtext))
            Invoke(New DisplayTerminalMessageOnMainGUI(AddressOf DisplayTerminalMessage), msgtext)
        Else
            ' display the message on a modal dialog
            Dim TermMsgfrm As New GemTerminalMessager
            TermMsgfrm.m_objMonitorStatus = objMonitorStatus
            TermMsgfrm.HostMessage.Text = msgtext
            TermMsgfrm.ShowDialog()

        End If
    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub HSMSComm_Click(sender As Object, e As EventArgs) Handles HSMSComm.Click
        Dim HSMS As New HSMSSettings
        HSMS.ShowDialog()
    End Sub
End Class


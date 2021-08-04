﻿Imports System.IO
Imports System.Net
Imports System.Net.Cache
Imports System.Threading
Imports Newtonsoft.Json.Linq

Public Class MainForm

    Private Shared Provinces As New List(Of Province)

    Shared Sub New()

        CheckForIllegalCrossThreadCalls = False

        Dim policy As New HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore)
        HttpWebRequest.DefaultCachePolicy = policy

        Dim Bari As New Province With {
            .CompanyCode = "C160114",
            .DeliveryType = "SSN"
        }

        Bari.Facilities.Add("14332")
        Bari.Facilities.Add("14334")
        Bari.Facilities.Add("14362")
        Bari.Facilities.Add("14450")
        Bari.Facilities.Add("14397")
        Bari.Facilities.Add("14455")
        Bari.Facilities.Add("14487")
        Bari.Facilities.Add("14383")
        Bari.Facilities.Add("14354")
        Bari.Facilities.Add("14379")
        Bari.Facilities.Add("14373")
        Bari.Facilities.Add("14375")
        Bari.Facilities.Add("14480")
        Bari.Facilities.Add("14336")
        Bari.Facilities.Add("14377")
        Bari.Facilities.Add("14385")
        Bari.Facilities.Add("14419")
        Bari.Facilities.Add("14421")
        Bari.Facilities.Add("14367")
        Bari.Facilities.Add("14426")
        Bari.Facilities.Add("14371")
        Bari.Facilities.Add("14463")
        Bari.Facilities.Add("14358")


        Dim BAT As New Province With {
            .CompanyCode = "C160113",
            .DeliveryType = "SSN"
        }

        BAT.Facilities.Add("102278")
        BAT.Facilities.Add("102264")
        BAT.Facilities.Add("102272")
        BAT.Facilities.Add("102274")
        BAT.Facilities.Add("102277")
        BAT.Facilities.Add("102286")
        BAT.Facilities.Add("102292")
        BAT.Facilities.Add("102287")
        BAT.Facilities.Add("102259")
        BAT.Facilities.Add("102290")


        Dim Brindisi As New Province With {
            .CompanyCode = "C160106",
            .DeliveryType = "SSN"
        }

        Brindisi.Facilities.Add("12538")
        Brindisi.Facilities.Add("12559")
        Brindisi.Facilities.Add("12577")
        Brindisi.Facilities.Add("12551")
        Brindisi.Facilities.Add("12544")
        Brindisi.Facilities.Add("12562")
        Brindisi.Facilities.Add("12557")
        Brindisi.Facilities.Add("12561")
        Brindisi.Facilities.Add("12550")
        Brindisi.Facilities.Add("12548")
        Brindisi.Facilities.Add("12543")
        Brindisi.Facilities.Add("12571")
        Brindisi.Facilities.Add("12495")
        Brindisi.Facilities.Add("12498")
        Brindisi.Facilities.Add("12499")
        Brindisi.Facilities.Add("12496")
        Brindisi.Facilities.Add("12497")


        Dim Foggia As New Province With {
            .CompanyCode = "C160115",
            .DeliveryType = "LP"
        }

        Foggia.Facilities.Add("ASL22")
        Foggia.Facilities.Add("ASL35")
        Foggia.Facilities.Add("ASL37")
        Foggia.Facilities.Add("ASL4")
        Foggia.Facilities.Add("ASL17")
        Foggia.Facilities.Add("ASL20")
        Foggia.Facilities.Add("ASL10")
        Foggia.Facilities.Add("ASL16")
        Foggia.Facilities.Add("ASL5")
        Foggia.Facilities.Add("ASL42")
        Foggia.Facilities.Add("ASL41")
        Foggia.Facilities.Add("ASL36")
        Foggia.Facilities.Add("ASL45")
        Foggia.Facilities.Add("ASL47")
        Foggia.Facilities.Add("ASL25")
        Foggia.Facilities.Add("ASL40")
        Foggia.Facilities.Add("ASL32")


        Dim Lecce As New Province With {
            .CompanyCode = "C160116",
            .DeliveryType = "SSN"
        }

        Lecce.Facilities.Add("400200")
        Lecce.Facilities.Add("900503")
        Lecce.Facilities.Add("900603")
        Lecce.Facilities.Add("900201")
        Lecce.Facilities.Add("900903")
        Lecce.Facilities.Add("300400")
        Lecce.Facilities.Add("900203")
        Lecce.Facilities.Add("700700")
        Lecce.Facilities.Add("800200")
        Lecce.Facilities.Add("900403")


        Dim Taranto As New Province With {
            .CompanyCode = "C160112",
            .DeliveryType = "SSN"
        }

        Taranto.Facilities.Add("12227")
        Taranto.Facilities.Add("12228")
        Taranto.Facilities.Add("12229")
        Taranto.Facilities.Add("12226")
        Taranto.Facilities.Add("12225")
        Taranto.Facilities.Add("12231")
        Taranto.Facilities.Add("12230")

        Provinces.Add(Bari)
        Provinces.Add(BAT)
        Provinces.Add(Brindisi)
        Provinces.Add(Foggia)
        Provinces.Add(Lecce)
        Provinces.Add(Taranto)

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CBBari.Tag = Provinces(0)
        CBBAT.Tag = Provinces(1)
        CBBrindisi.Tag = Provinces(2)
        CBFoggia.Tag = Provinces(3)
        CBLecce.Tag = Provinces(4)
        CBTaranto.Tag = Provinces(5)

        AppointmentsList.ListViewItemSorter = New ListComparator

    End Sub

    Private Sub CB_CheckedChanged(sender As Object, e As EventArgs) Handles CBBari.CheckedChanged, CBBAT.CheckedChanged, CBBrindisi.CheckedChanged, CBFoggia.CheckedChanged, CBLecce.CheckedChanged, CBTaranto.CheckedChanged

        Dim checkBox As CheckBox = sender
        Dim province As Province = checkBox.Tag

        province.Enabled = checkBox.Checked

        Dim canSearch As Boolean = False
        For Each prov As Province In Provinces

            If prov.Enabled Then

                canSearch = True
                Exit For

            End If

        Next

        Search.Enabled = canSearch

    End Sub

    Private Sub AppointmentsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AppointmentsList.SelectedIndexChanged
        Reserve.Enabled = AppointmentsList.SelectedItems.Count > 0
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click

        AppointmentsList.Items.Clear()

        SearchProgress.Maximum = 0
        SearchProgress.Minimum = 0
        SearchProgress.Value = 0

        For Each province In Provinces

            If province.Enabled Then SearchProgress.Maximum += province.Facilities.Count

        Next

        If SearchProgress.Maximum > 0 Then

            Search.Enabled = False

            CBBari.Enabled = False
            CBBAT.Enabled = False
            CBBrindisi.Enabled = False
            CBFoggia.Enabled = False
            CBLecce.Enabled = False
            CBTaranto.Enabled = False

            For Each province In Provinces

                If Not province.Enabled Then Continue For

                For Each facility In province.Facilities

                    Dim checkParams As New CheckParams With {
                        .Province = province,
                        .FacilityCode = facility
                    }

                    Dim thread As New Thread(AddressOf CheckFacility)
                    thread.Start(checkParams)

                Next

            Next

        End If

    End Sub

    Private Sub Reserve_Click(sender As Object, e As EventArgs) Handles Reserve.Click

        Reserve.Enabled = False

        Application.DoEvents()

        Dim baseURL = "https://www.sanita.puglia.it/sanita-api/covid19/reservation/register"
        Dim url = baseURL + "?"

        url += "platform" + "=" + "WEB" + "&"
        url += "functionality" + "=" + "PRENOTAZIONE_VACCINO"

        Dim request As HttpWebRequest = WebRequest.Create(url)

        request.ContentType = "application/json"
        request.Accept = "application/json"
        request.Method = "POST"
        request.Timeout = 1 * 60 * 1000

        Dim data As New JObject

        Dim appointments As New JArray
        appointments.Add(AppointmentsList.SelectedItems.Item(0).Tag)

        data.Add("appointments", appointments)

        Dim userInfo As New JObject
        userInfo.Add("email", Email.Text)
        userInfo.Add("phone", Phone.Text)
        userInfo.Add("fiscalCode", FiscalCode.Text)
        userInfo.Add("healthInsuranceCard", HealthCardID.Text)

        data.Add("userInfo", userInfo)

        Dim dataBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(data.ToString)
        Dim stream As Stream = request.GetRequestStream
        stream.Write(dataBytes, 0, dataBytes.Length)
        stream.Flush()
        stream.Close()

        Try

            Dim response As HttpWebResponse = request.GetResponse
            Dim responseStream As Stream = response.GetResponseStream
            Dim reader As New StreamReader(responseStream)
            Dim content As String = reader.ReadToEnd

            reader.Close()
            reader.Dispose()

            responseStream.Close()
            responseStream.Dispose()

            response.Close()
            response.Dispose()

            data = JObject.Parse(content)
            MsgBox(data.ToString)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Reserve.Enabled = True

    End Sub

    Private Sub Download_Click(sender As Object, e As EventArgs) Handles Download.Click

        Dim reservationID As String = InputBox("Codice prenotazione")

        Dim provinceDialog = New ChooseProvince()
        If provinceDialog.ShowDialog() = DialogResult.OK Then

            Dim dialog As New SaveFileDialog With {
                .Filter = "PDF|*.pdf"
            }

            If dialog.ShowDialog = DialogResult.OK Then

                Dim url As String = "https://www.sanita.puglia.it/sanita-api/covid19/reservation/"
                url += reservationID
                url += "/patient/"
                url += FiscalCode.Text
                url += "/company/"
                url += Provinces(provinceDialog.Provincia).CompanyCode
                url += "/download-reminder?platform=WEB&functionality=GESTIONE_PRENOTAZIONI&accessMode=ANONIMO&healthInsuranceCard="
                url += HealthCardID.Text

                Dim request As HttpWebRequest = WebRequest.Create(url)

                request.Accept = "application/json"
                request.Method = "GET"
                request.Timeout = 1 * 60 * 1000

                Try

                    Dim response As HttpWebResponse = request.GetResponse
                    Dim responseStream As Stream = response.GetResponseStream
                    Dim reader As New StreamReader(responseStream)
                    Dim content As String = reader.ReadToEnd

                    reader.Close()
                    reader.Dispose()

                    responseStream.Close()
                    responseStream.Dispose()

                    response.Close()
                    response.Dispose()

                    Dim data As JObject = JObject.Parse(content)

                    Dim reminder As String = data.Value(Of String)("reminder")
                    Dim decodedReminder As Byte() = Convert.FromBase64String(reminder)

                    Dim stream As New FileStream(dialog.FileName, FileMode.Create)
                    stream.Write(decodedReminder, 0, decodedReminder.Length)
                    stream.Flush()
                    stream.Close()
                    stream.Dispose()

                    MsgBox("Salvataggio completato")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If

        End If

    End Sub

    Private Sub CheckFacility(params As CheckParams)

        Console.WriteLine("Checking facility " + params.FacilityCode)

        Dim baseURL = "https://www.sanita.puglia.it/sanita-api/covid19/appointments/patient/"
        Dim url = baseURL + FiscalCode.Text + "?"

        url += "healthServicesRegCodes" + "=" + "994A" + "&"
        url += "deliveryType" + "=" + params.Province.DeliveryType + "&"
        url += "companyCodes" + "=" + params.Province.CompanyCode + "&"
        url += "facilityCode" + "=" + params.FacilityCode + "&"
        url += "cupDate" + "=" + "2021-06-12" + "&"
        url += "isFragile" + "=" + "false" + "&"
        url += "healthInsuranceCard" + "=" + HealthCardID.Text + "&"
        url += "platform" + "=" + "WEB" + "&"
        url += "accessMode" + "=" + "ANONIMO" + "&"
        url += "functionality" + "=" + "PRENOTAZIONE_VACCINO"

        Dim request As HttpWebRequest = WebRequest.Create(url)

        request.Accept = "application/json"
        request.Method = "GET"
        request.Timeout = 5 * 60 * 1000

        Dim response As HttpWebResponse

        Try
            response = request.GetResponse

            Dim responseStream As Stream = response.GetResponseStream
            Dim reader As New StreamReader(responseStream)
            Dim content As String = reader.ReadToEnd

            reader.Close()
            reader.Dispose()

            responseStream.Close()
            responseStream.Dispose()

            response.Close()
            response.Dispose()

            Dim data As JObject = JObject.Parse(content)
            Dim list As JArray = data.Value(Of JArray)("appointmentsList")

            If list IsNot Nothing AndAlso list.Count > 0 Then

                Dim firstAppointment As JObject = list.First
                Dim listItem As New ListViewItem(firstAppointment.Value(Of String)("location"))
                listItem.SubItems.Add(FormatDate(firstAppointment.Value(Of String)("date")))
                listItem.SubItems.Add(firstAppointment.Value(Of String)("time"))
                listItem.Tag = firstAppointment

                AppointmentsList.Items.Add(listItem)

            End If

            Console.WriteLine("Checked facility " + params.FacilityCode)

        Catch ex As Exception

            Console.WriteLine("Failed checking facility " + params.FacilityCode)

        End Try

        SyncLock SearchProgress

            SearchProgress.Value += 1

            If SearchProgress.Value = SearchProgress.Maximum Then

                Search.Enabled = True

                CBBari.Enabled = True
                CBBAT.Enabled = True
                CBBrindisi.Enabled = True
                CBFoggia.Enabled = True
                CBLecce.Enabled = True
                CBTaranto.Enabled = True

            End If

        End SyncLock

    End Sub

    Private Function FormatDate(dateString As String)
        Return dateString.Substring(0, 4) + "/" + dateString.Substring(4, 2) + "/" + dateString.Substring(6, 2)
    End Function

    Private Class Province

        Public Property CompanyCode As String
        Public Property DeliveryType As String
        Public Property Facilities As New List(Of String)
        Public Property Enabled As Boolean = False

    End Class

    Private Class CheckParams

        Public Property Province As Province
        Public Property FacilityCode As String

    End Class

    Private Class ListComparator
        Implements IComparer

        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare

            Dim firstItem As ListViewItem = x
            Dim secondItem As ListViewItem = y

            Dim firstDate As String = firstItem.SubItems.Item(1).Text + " " + firstItem.SubItems.Item(2).Text
            Dim secondDate As String = secondItem.SubItems.Item(1).Text + " " + secondItem.SubItems.Item(2).Text

            Return String.Compare(firstDate, secondDate)

        End Function

    End Class

End Class
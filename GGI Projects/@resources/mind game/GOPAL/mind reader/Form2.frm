VERSION 5.00
Begin VB.Form Form2 
   Caption         =   "Form2"
   ClientHeight    =   3015
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   4560
   LinkTopic       =   "Form2"
   ScaleHeight     =   3015
   ScaleWidth      =   4560
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "NEXT"
      BeginProperty Font 
         Name            =   "Goudy Stout"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   5640
      TabIndex        =   0
      Top             =   4800
      Width           =   2295
   End
   Begin VB.Label Label1 
      Caption         =   "THINK ANY NUMBER"
      BeginProperty Font 
         Name            =   "Goudy Stout"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1695
      Left            =   4800
      TabIndex        =   1
      Top             =   1320
      Width           =   4815
   End
End
Attribute VB_Name = "Form2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
Form2.Hide
Form3.Show
End Sub

Private Sub Form_Load()
Form2.BackColor = vbBlue
Label1.BackColor = vbBlue
Label1.ForeColor = vbWhite
End Sub


Imports Integration.BE
Imports Integration.BL

Module mdlVariblesG

    Public cCodCorpoMedica As String = "3400000000"

    Public cPerAutToken As String = ""
    Public nFlagToken As Integer = 0
    Public cKeyToken As String = ""

    Public vCtaCteRecibo As String

    'DataTable (Clase).- Representa una tabla de datos en memoria.
    Public cDT As New DataTable

    REM para controlar el estado de web cam 0=ok, 1=error
    Public StatusWebCam As Long = 0

    Public nImpAnticipo As Double = 0.0

    Public traza As String = String.Empty

    REM form servicios caragado
    Public FormServicios As Integer = 0
    Public FromParentesco As Integer = 0

    Public frm As New FormPrcFormaPagoDetalle

    'Flag que indica si puede aplicar descuentos
    Public frmSisGruCodigo As Integer = 0
    Public nFlagDscto As Integer = 0 '--1 - Permitir, 0 - No tiene acceso
    Public nFlagDescMax As Boolean = False 'False: No puede dar descuentos True: Puede dar descuentos hasta tope definido
    Public nFlagCortesia As Integer = 0 '--1 Permitir Cortesía   0 No permitir cortesía

    'para Contante
    'Public RequestConst As New BE.Constante.BE_ReqConstante
    Public ObjConst As New BL_Constante

    'Para Photos
    Public RequestImg As New Persona.BE_ReqPerPhoto
    Public ObjImg As New BL_Personas

    'para Interface
    Public RequestInterface As New [Interface].BE_ReqInterface
    Public ObjInterface As New BL_Interface

    'Capa Aplicacion y Dominio para "Sistema"
    Public ObjetoSistema As New Sistema.BE_ReqSistema
    Public ObjSistemaServicio As New BL_Sistema

    'Interface configuration
    Public BLInterfaceCFG As New BL_Interface

    Public StrUser As String 'cPerCodigo actual del sistema logueado

    Public StrcPerJuridica As String 'cPerCodigo Empresa actual

    Public StrNroDocuPersona As String

    Public FieldFoto As Byte()

    'Variables para envio de registros
    Public StrPasaValores As String 'TokenKey
    Public StrPasaValoresParentesco As String 'TokenKey
    Public StrPasaAdmFicha As String 'TokenKey
    Public StrFichaAtencion As String 'TokenKey

    Public nOperacion As Integer
    Public OperacionPago As Integer = 0
    Public nFlagPersona As Integer
    Public nFlagNewPariente As Integer = 0
    Public nFormPerPredeterminado As Integer

    Public cPathRPT As String 'para los reportes
    Public cNroCaja As String 'la sabe que nro de caja es

    'var. fecha del servidor
    Public dFechaSistema As String
    Public dFechaHoraSistema As String

    'Flag AdmSolAtencion
    Public nFlagAdmision As Integer = 0 '0=Nuevo, 1=modificando

    Public dtGenerico As New DataTable

    Public gnAdelantoReloj As Long = -11 * 60

    REM ----------
    REM constante
    REM ----------
    REM 1013 natural
    Public Const nConPerNatural As Double = 1013
    REM 1012 juridica
    Public Const nConPerJuridica As Double = 1012

    Public nAccionBotones As Long

    Public Enum nAccionButton
        nAccionNuevo = 1000
        nAccionGrabar = 1001
        nAccionCancel = 1002
        nAccionEdit = 1002
        nAccionFind = 1004
        nAccionCerrar = 1005
    End Enum

    Public Enum nConTipoPersona
        nPerNatural = 1
        nPerJuridica = 2
    End Enum

    Public Enum nConTipoDocPerNatural
        nDNI = 25
    End Enum

    Public Enum nConTipoDocPerJuridica
        nRUC = 11
    End Enum

    Public Enum nFomaPago
        nEfectivo = 1
        nCheque = 2
        nDepositoBco = 3
        nTarjetaCred = 4
        nCortesia = 5
        nAnticipo = 6
    End Enum

    Public Enum nTipoMoneda
        nSoles = 1
        nDolar = 2
        nEuros = 3
    End Enum
    Public Const gsQBCmdBtnMsg As String = "QB_MSG"

    Public Enum nSisGruCodigo
        AdmisionMedica = 3500001
        AdmisionAprobador = 3500002
        AdmisionCortesia = 3500003
        AdmisionDescuentosMax = 3500004
        AnulacionComprobantes = 3500005
        ModificadorFechasComprobante = 3500007
    End Enum

    Public Enum FiltroServicio
        nFicha = 1
        nCampana = 2
        nPerfil = 3
    End Enum

End Module

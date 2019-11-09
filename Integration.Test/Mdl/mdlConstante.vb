Public Module mdlConstante

    Public KeyItem As String = "K"
    Public KeyEscuela As String = "E"
    Public SubPeriodo As Long = 1056
    Public EstadoCursoMatriculado As Long = 1077
    Public Seccion As Long = 1093
    Public ModalidadEstudios As Long = 5001
    Public gConEstDocumento As Long = 1066
    Public gConTipoDocumento As Long = 1063
    Public gConUnidades As Long = 1004
    Public gConTipoDscto As Long = 1132

    'Jerarquía de Módulos
    Public Const Mod_AdmisionMedica = "28"

    'Glosas 
    Public Const sGlosaCtaCteCorriente = "Programación Pago Ficha Atención"
    Public Const sGlosaCtaCteCorrienteAnticipo = "Programación Pago de Anticipo Ficha Atención"

    'Constante (1015)
    Enum TipoActividad
        nPerTipoAlumno = 3
        nPerTipoTerceros = 15
        nPerTipoCliente = 16
        nPerRelTipoEmpConvenio = 30
        nPerRelTipoMedico = 40
        nPerRelTipoMedicoSinComision = 41
        nPerRelTipoLabExterno = 50
        nPerRelTipoCentroSalud = 51
        nPerRelTipoCampana = 52
        nPerRelTipoPromotor = 90
    End Enum

    'Constante (1001)
    Enum TipoMoneda
        nSoles = 1
        nDolar = 2
        nEuro = 3
    End Enum

    'Constante (1116)
    Enum EstadoFichaAtencion
        nPendientePago = 1
        nProgramado = 2
        nPagoRealizado = 3
        nTomaExamen = 4
        nFinalizado = 5
        nEntregado = 6
        nAnulado = 7
    End Enum

    'Interface
    Enum TipoAtencion
        Particular = 1001
        LabExterno = 1002
        Convenio = 1003
        AtencionExterna = 1004
        CentroSalud = 1005
        Campaña = 1006
    End Enum

    'Tipo Docu (Interface nIntClase=7004 AND nIntTipo=1000)
    Enum TipoDocuVta
        Factura = 3001
        BoletaVta = 3003
        TBoleta = 3005
        TFactura = 3021
        Ticket = 3012
    End Enum

    Enum FiltroFicha
        nNroFichaAtencion = 0
        nDNIRUC = 1
        nApellidos = 2
        nRangoFechas = 3
    End Enum

    Enum TipoMuestraDscto
        nProcesoLocal = 0 'Normal (Aplica descuento) 
        nCampana = 1  'Campaña (No Aplica descuento)
        nPerfil = 2 'Perfil (No Aplica descuento)
        nProcesoLabTercero = 9 'Muestra enviadas a Lab. Terceros (No Aplica descuento) Equivalente = 0 en DetAdmSolAtencion(nFlag)
    End Enum

    Enum Trace
        RegistroPersona = 406303 'Registro Persona
        ActualizarPersona = 410401  'Editar datos de persona
        RegistroServicio = 2048
        ActualizandoServicio = 2049
        AnulacionComprobante = 2051
    End Enum

    Enum TipoDsctoAplica
        Porcentaje = 1
        PrecioFijo = 2
    End Enum

    Enum AccionForm
        Add = 1
        Edit = 2
        Del = 3
    End Enum

End Module

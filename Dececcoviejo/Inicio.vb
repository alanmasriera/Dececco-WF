Imports System.Globalization
Imports System.Threading

Module Inicio

    Public oBackup As New Backup
    Public BanderaBackup As Integer = 0

    Public BanderaCheque As Integer = 0

    Public vgFormularioPadre As String = ""
    '''''''''''''''''''''
    'definicion de clases
    '''''''''''''''''''''
    Public oClaseHora As New ClaseHora
    Public oCalculoSueldo As New CalculoSueldo

    Public oAsiento_modelo As New Asiento_modelo
    Public BanderaAsiento_modelo As Integer = 0

    Public oAsignacion_iva As New Asignacion_iva
    Public BanderaAsignacion_iva As Integer = 0

    Public oBanco As New Banco
    Public BanderaBanco As Integer = 0

    Public oCalle As New Calle
    Public BanderaCalle As Integer = 0

    Public oChequeLibrado As New Cheques_librados
    Public BanderaLibrado As Integer = 0

    Public oCheque_proveedor As New Cheque_proveedor
    Public BanderaCheque_proveedor As Integer = 0

    Public oCheque_proveedor_2 As New Cheque_proveedor_2
    Public BanderaCheque_proveedor_2 As Integer = 0

    Public oChequeRecibido As New Cheques_recibidos
    Public BanderaChequeRecibido As Integer = 0

    Public oChequera As New Chequeras
    Public BanderaChequera As Integer = 0

    Public oCheque_recibido As New Cheque_recibido
    Public BanderaCheque_recibido As Integer = 0

    Public oCheque_librado As New Cheque_librado
    Public BanderaCheque_librado As Integer = 0

    Public oCheque_temporal As New Cheque_temporal
    Public BanderaCheque_temporal As Integer = 0

    Public oCliente As New Cliente
    Public BanderaCliente As Integer = 0

    Public oCliente_maestro As New Cliente_maestro
    Public BanderaCliente_maestro As Integer = 0

    Public oCondicion_iva As New Condicion_iva
    Public BanderaCondicion_iva As Integer = 0

    Public oConsulta_saldo_proveedor As New Consulta_saldo_proveedor
    Public BanderaConsulta_saldo_proveedor As Integer = 0

    Public oCredito As New Creditos
    Public BanderaCredito As Integer = 0

    Public oCuenta As New Cuentas
    Public BanderaCuenta As Integer = 0

    Public oCuenta_imputable As New Cuenta_imputable
    Public BanderaCuenta_imputable As Integer = 0

    Public oCuerpo_factura As New Cuerpo_factura
    Public BanderaCuerpo_factura As Integer = 0

    Public oCuerpo_factura_exporta As New Cuerpo_factura_exporta
    Public BanderaCuerpo_factura_exporta As Integer = 0

    Public oCuerpo_factura_proveedor As New Cuerpo_factura_proveedor
    Public BanderaCuerpo_factura_proveedor As Integer = 0

    Public oCuerpo_movimiento_hora As New Cuerpo_movimiento_hora
    Public BanderaCuerpo_movimiento_hora As Integer = 0

    Public oCuerpo_movimiento_libro As New Cuerpo_movimiento_libro
    Public BanderaCuerpo_movimiento_libro As Integer = 0

    'agregado
    Public oCuerpo_orden_compra As New Cuerpo_orden_compra
    Public BanderaCuerpo_orden_compra As Integer = 0

    Public oCuerpo_remito As New Cuerpo_remito
    Public BanderaCuerpo_remito As Integer = 0

    Public oDebito As New Debitos
    Public BanderaDebito As Integer = 0

    Public oDepositoEfectivo As New Depositos_efectivo
    Public BanderaDepositoEfectivo As Integer = 0

    Public oDia As New Dia
    Public BanderaDia As Integer = 0

    Public oDia_tarde As New Dia_tarde
    Public BanderaDia_tarde As Integer = 0

    Public oEgreso_efectivo As New Egreso_efectivo
    Public BanderaEgreso_efectivo As Integer = 0

    Public oEmpleado As New Empleado
    Public BanderaEmpleado As Integer = 0

    Public oEmpleado_renglon As New Empleado_renglon
    Public BanderaEmpleado_renglon As Integer = 0

    Public oEmpresa As New Empresa
    Public BanderaEmpresa As Integer = 0

    Public oEgreso_efectivo_proveedor As New Egreso_efectivo_proveedor
    Public BanderaEgreso_efectivo_proveedor As Integer = 0

    Public oFactura As New Factura
    Public BanderaFactura As Integer = 0

    Public oFactura_exporta As New Factura_exporta
    Public BanderaFactura_exporta As Integer = 0

    Public oFactura_proveedor As New Factura_proveedor
    Public BanderaFactura_proveedor As Integer = 0

    Public oFactura_recibo_proveedor As New Factura_recibo_proveedor
    Public BanderaFactura_recibo_proveedor As Integer = 0

    Public oGasto As New Gastos
    Public BanderaGasto As Integer = 0

    Public oGrupo_permiso As New Grupo_permiso
    Public BanderaGrupo_permiso As Integer = 0

    Public oGrupo_producto As New Grupo_producto
    Public BanderaGrupo_producto As Integer = 0

    Public oGrupo_usuario As New Grupo_usuario
    Public BanderaGrupo_usuario As Integer = 0

    Public oItem As New Item
    Public BanderaItem As Integer = 0

    Public oIngreso_efectivo As New Ingreso_efectivo
    Public BanderaIngreso_efectivo As Integer = 0

    Public oIva As New Iva
    Public BanderaIva As Integer = 0

    Public oIva_compra As New Iva_compra
    Public BanderaIva_compra As Integer = 0

    Public oIva_compra_temp As New Iva_compra_temp
    Public BanderaIva_compra_temp As Integer = 0

    Public oIva_venta As New Iva_venta
    Public BanderaIva_venta As Integer = 0

    Public oIva_venta_temp As New Iva_venta_temp
    Public BanderaIva_venta_temp As Integer = 0

    Public oLibro As New Libro
    Public BanderaLibro As Integer = 0

    Public oLimite As New Limite
    Public BanderaLimite As Integer = 0

    Public oLocalidad As New Localidad
    Public BanderaLocalidad As Integer = 0

    Public oLog_Error As New Log_error
    Public BanderaLog_Error As Integer = 0

    Public oMarca As New Marca
    Public BanderaMarca As Integer = 0

    'Public oMensual As New Mensual
    'Public BanderaMensual As Integer = 0

    Public oMovimiento_hora As New Movimiento_hora
    Public BanderaMovimiento_hora As Integer = 0

    Public oMovimiento_libro As New Movimiento_libro
    Public BanderaMovimiento_libro As Integer = 0

    Public oMovimiento_manual As New Movimiento_manual
    Public BanderaMovimiento_manual As Integer = 0

    Public oMoneda As New Moneda
    Public BanderaMoneda As Integer = 0

    Public oNivel1 As New Nivel1
    Public BanderaNivel1 As Integer = 0

    Public oNivel2 As New Nivel2
    Public BanderaNivel2 As Integer = 0

    Public oNivel3 As New Nivel3
    Public BanderaNivel3 As Integer = 0

    Public oObra As New Obra
    Public BanderaObra As Integer = 0

    Public oObra_social As New Obra_social
    Public BanderaObra_social As Integer = 0

    Public oOrden_compra As New Orden_compra
    Public BanderaOrden_compra As Integer = 0

    Public oPago_cliente As New Pago_cliente
    Public BanderaPago_cliente As Integer = 0

    Public oPago_iva As New Pago_iva
    Public BanderaPago_iva As Integer = 0

    Public oPago_proveedor As New Pago_proveedor
    Public BanderaPago_proveedor As Integer = 0

    Public oPeriodo As New Periodo
    Public BanderaPeriodo As Integer = 0

    Public oPermiso As New Permiso
    Public BanderaPermiso As Integer = 0

    Public oPersona As New Persona
    Public BanderaPersona As Integer = 0

    Public oPrecio As New Precio
    Public BanderaPrecio As Integer = 0

    Public oPresupuesto As New Presupuesto
    Public BanderaPresupuesto As Integer = 0

    Public oCuerpo_presupuesto As New Cuerpo_presupuesto
    Public BanderaCuerpo_presupuesto As Integer = 0

    Public oCuerpo_Cuerpo_presupuesto As Cuerpo_presupuesto
    Public BanderaCuerpo_Cuerpo_presupuesto As Integer = 0

    Public oProducto As New Producto
    Public BanderaProducto As Integer = 0

    Public oProveedor As New Proveedor
    Public BanderaProveedor As Integer = 0

    Public oProvincia As New Provincia
    Public BanderaProvincia As Integer = 0

    Public oRecibo As New Recibo
    Public BanderaRecibo As Integer = 0

    Public oRecibo_proveedor As New Recibo_proveedor
    Public BanderaRecibo_proveedor As Integer = 0

    Public oRecibo_sueldo As New Recibo_sueldo
    Public BanderaRecibo_sueldo As Integer = 0

    Public oRecibo_sueldo_temporal As New Recibo_sueldo_temporal
    Public BanderaRecibo_sueldo_temporal As Integer = 0

    Public oRecibo_cliente As New Recibo_cliente
    Public BanderaRecibo_cliente As Integer = 0

    Public oRecibo_cliente_cheque As New Recibo_cliente_cheque
    Public BanderaRecibo_cliente_cheque As Integer = 0

    Public oRenglon As New Renglon
    Public BanderaRenglon As Integer = 0

    Public oResumen_caja_temporal As New Resumen_caja_temporal
    Public BanderaResumen_caja_temporal As Integer = 0

    Public oResumen_cliente As New Resumen_cliente
    Public BanderaResumen_cliente As Integer = 0

    Public oResumen_cliente_temporal As New Resumen_cliente_temporal
    Public BanderaResumen_cliente_temporal As Integer = 0

    Public oResumenCuenta As New Resumen_cuenta
    Public BanderaResumenCuenta As Integer = 0

    Public oResumen_cuenta_2 As New Resumen_cuenta_2
    Public BanderaResumen_cuenta_2 As Integer = 0

    Public oResumen_cuenta_caja As New Resumen_cuenta_caja
    Public BanderaResumen_cuenta_caja As Integer = 0

    Public oResumen_cuenta_caja_2 As New Resumen_cuenta_caja_2
    Public BanderaResumen_cuenta_caja_2 As Integer = 0

    Public oResumen_iva As New Resumen_iva
    Public BanderaResumen_iva As Integer = 0

    Public oResumen_iva_temporal As New Resumen_iva_temporal
    Public BanderaResumen_iva_temporal As Integer = 0

    Public oResumen_proveedor As New Resumen_proveedor
    Public BanderaResumen_proveedor As Integer = 0

    Public oResumen_proveedor_temporal As New Resumen_proveedor_temporal
    Public BanderaResumen_proveedor_temporal As Integer = 0

    Public oResumen_temporal As New Resumen_temporal
    Public BanderaResumen_temporal As Integer = 0

    Public oRemito As New Remito
    Public BanderaRemito As Integer = 0

    Public oSaldo As New Saldos
    Public BanderaSaldo As Integer = 0

    Public oSaldoBanco As New Saldo_bancos
    Public BanderaSaldoBanco As Integer = 0

    Public oSaldo_caja As New Saldo_caja
    Public BanderaSaldo_caja As Integer = 0

    Public oSaldo_cliente As New Saldo_cliente
    Public BanderaSaldo_cliente As Integer = 0

    Public oSaldo_iva As New Saldo_iva
    Public BanderaSaldo_iva As Integer = 0

    Public oSaldo_proveedor As New Saldo_proveedor
    Public BanderaSaldo_proveedor As Integer = 0

    Public oSereno As New Sereno
    Public BanderaSereno As Integer = 0

    Public oSubtipo_producto As New Subtipo_producto
    Public BanderaSubtipo_producto As Integer = 0

    Public oTemp1 As New Temp1
    Public BanderaTemp1 As Integer = 0

    Public oTemp_actividad_proyecto As New Temp_actividad_proyecto
    Public BanderaTemp_actividad_proyecto As Integer = 0

    Public oTipo_asiento As New Tipo_asiento
    Public BanderaTipo_asiento As Integer = 0

    Public oTipo_comprobante As New Tipo_comprobante
    Public BanderaTipo_comprobante As Integer = 0

    Public oTipo_dni As New Tipo_dni
    Public BanderaTipo_dni As Integer = 0

    Public oTipo_Empleado As New Tipo_empleado
    Public BanderaTipo_Empleado As Integer = 0

    Public oTipo_hora As New Tipo_hora
    Public BanderaTipo_hora As Integer = 0

    Public oTipo_periodo As New Tipo_periodo
    Public BanderaTipo_periodo As Integer = 0

    Public oTipo_producto As New Tipo_producto
    Public BanderaTipo_producto As Integer = 0

    Public oTipo_renglon As New Tipo_renglon
    Public BanderaTipo_renglon As Integer = 0

    Public oTotal_sueldo As New Total_sueldo
    Public BanderaTotal_sueldo As Integer = 0

    Public oTransferenciaBancaria As New Transferencias_bancarias
    Public BanderaTransferenciaBancaria As Integer = 0

    Public oUnidad As New Unidad
    Public BanderaUnidad As Integer = 0

    Public oUsuario As New Usuario
    Public BanderaUsuario As Integer = 0


    Public oForma_pago As New Forma_pago
    Public BanderaForma_pago As Integer = 0

    Public oMedio_entrega As New Medio_entrega
    Public BanderaMedio_entrega As Integer = 0

    Public oPreparo As New Usuario
    Public BanderaPreparo As Integer = 0

    Public oResponsable_calidad As New Usuario
    Public BanderaResponsable_calidad As Integer = 0

    Public oAprobo As New Usuario
    Public BanderaAprobo As Integer = 0

    Public oDireccion_general As New Usuario
    Public BanderaDireccion_general As Integer = 0

    Public oFirma As New Usuario
    Public BanderaFirma As Integer = 0

    Public oTipo_moneda As New Tipo_moneda
    Public BanderaTipo_moneda As Integer = 0


    Public oAlmacen As New Almacen
    Public BanderaAlmacen As Integer = 0


    Public oCodigo As New Codigo
    Public BanderaCodigo As Integer = 0




    Public opInicio As Boolean = True


    Public oActividad As New Actividad
    Public BanderaActividad As Integer = 0

    Public oActividad_proyecto As New Actividad_proyecto
    Public BanderaActividad_proyecto As Integer = 0

    Public oCalendario_usuario As New Calendario_usuario
    Public BanderaCalendario_usuario As Integer = 0

    Public oCategoria As New Categoria
    Public BanderaCategoria As Integer = 0

    Public oCategoria_voz As New Categoria_voz
    Public BanderaCategoria_voz As Integer = 0

    Public oContacto As New Contacto
    Public BanderaContacto As Integer = 0

    Public oCalendario As New Calendario
    Public BanderaCalendario As Integer = 0

    Public oControl As New Control
    Public BanderaControl As Integer = 0

    Public oCuerpo_movimiento_voz As New Cuerpo_movimiento_voz
    Public BanderaCuerpo_movimiento_voz As Integer = 0

    Public oEstado As New Estado
    Public BanderaEstado As Integer = 0

    Public oHora_a_devolver As New Hora_a_devolver
    Public BanderaHora_a_devolver As Integer = 0

    Public oLogueo As New Logueo
    Public BanderaLogueo As Integer = 0

    Public oMail As New Mail
    Public BanderaMail As Integer = 0

    Public oMail_contacto As New Mail_contacto
    Public BanderaMail_contacto As Integer = 0

    Public oMovimiento_voz As New Movimiento_voz
    Public BanderaMovimiento_voz As Integer = 0

    Public oPrecedencia As New Precedencia
    Public BanderaPrecedencia As Integer = 0

    Public oProyecto As New Proyecto
    Public BanderaProyecto As Integer = 0

    Public oSucursal As New Sucursal
    Public BanderaSucursal As Integer = 0

    Public oTipo_actividad As New Tipo_actividad
    Public BanderaTipo_actividad As Integer = 0

    Public oTipo_voz As New Tipo_voz
    Public BanderaTipo_voz As Integer = 0

    Public oVoz As New Voz
    Public BanderaVoz As Integer = 0

    Public oVoz_tipo_voz As New Voz_tipo_voz
    Public BanderaVoz_tipo_voz As Integer = 0

    Public oDetalle_recurso As New Detalle_recurso
    Public BanderaDetalle_recurso As Integer = 0

    Public oModificacion_arbol As New Modificacion_arbol
    Public BanderaModificacion_arbol As Integer = 0

    Public oStock As New Stock
    Public BanderaStock As Integer = 0

    Public oTipo_Egreso As New Tipo_egreso
    Public BanderaTipo_egreso As Integer = 0

    Public oRecibo_cliente_ingreso_efectivo As New Recibo_cliente_ingreso_efectivo
    Public BanderaRecibo_cliente_ingreso_efectivo As Integer

    Public oRecibo_cliente_cheque_2 As New Recibo_cliente_cheque_2
    Public BanderaRecibo_cliente_cheque_2 As Integer = 0

    Public oCondicion_Venta As New Condicion_venta
    Public BanderaCondicion_Venta As Integer = 0


    Public oTemp_grilla_pago_cliente As New Temp_grilla_pago_cliente
    Public BanderaoTemp_grilla_pago_cliente As Integer = 0

    Public oTipo_proveedor As New Tipo_proveedor
    Public BanderaTipo_Proveedor As Integer = 0

    Public oUsuario_permiso As New Usuario_permiso
    Public BanderaUsuario_permiso As Integer = 0
    'agregado
    'Public NombreUsuario As String = ""
    'Public CodigoUsuario As Integer = 0

    '___________________________________________________________
    'banderas de menu contextual

    Public banderacopiarproyecto As Integer = 0
    Public banderacopiarestructura As Integer = 0

    '___________________________________________________________
    'variable comanda
    Public BanderaCierre As Integer = 0
    Public BanderaTramitePedido As Integer = 0
    Public NombreFromPadre As String = ""

    'variable de usuario
    Public vgNombreUsuario As String = ""
    Public vgCodigoUsuario As Integer = 0
    Public vgPermisoUsuario As Integer = 0
    Public vgCodigoMovimientoHora As Integer = 0
    Public vgHoraIngreso As DateTime
    Public vgCodigoPM As Integer = 0
    Public vgProyectoSeleccionado As String = ""
    Public vgControlLogueo As Boolean = False
    Public vgNombreFormulario As String = ""
    Public vgNombrePermiso As String = ""
    Public vgNumeroControl As Integer = 0
    Public vgCuentaProveedorResta As String = ""

    '_______________________________________________________
    'control click de botones
    Public vgbanderacontrol As Boolean = False
    Public vgbanderactividad As Boolean = False
    Public vgbanderaproyecto As Boolean = False
    '_______________________________________________________
    'variable de consultas
    Public BanderaConsulta As String
    Public BanderaConsultaGeneral As String
    Public odtConsultaGeneral As New DataTable
    Public odtConsultaGeneralSuma As New DataTable
    Public BanderaConsulta_2 As String
    Public odtConsultaGeneral_2 As New DataTable
    Public strTituloConsultaGeneral As String = ""
    Public strDetalleConsultaGeneral As String = ""
    Public strHoraFormateada As String = ""
    Public odtConsultaBancos As New DataTable
    Public Bandera_consulta_iva As String = ""
    Public id_iva_consulta As Integer = 0
    Public datFecha_inicio As DateTime
    Public datFecha_fin As DateTime
    Public bandera_imprime_prov As Integer = 0
    Public id_factura_global As Integer = 0
    Public numero_factura_global As String = ""
    Public bandera_imprime As Integer = 0
    Public Banderabtn As Integer = 0
    Public vgBanderaprint As String = ""
    Public banderamodifact As Integer = 0

    'variables de reportes
    Public parametro_empleado_prn As String = ""
    Public Banderaprint As String = ""
    Public parametro_id_empresa As Integer = 0
    Public parametro_id_empleado As Integer = 0
    Public parametro_fecha_inicio As DateTime
    Public parametro_fecha_fin As DateTime
    Public parametro_fecha_old As DateTime
    Public parametro_empleado As String = ""
    Public parametro_empleado_pago As String = ""
    Public parametro_empleado_sueldo As String = ""
    Public parametro_empleado_total As String = ""
    Public parametro_empleado_hora As String = ""
    Public parametro_empleado_hora_formateada As String = ""
    Public parametro_total As Decimal = 0
    Public parametro_id_pago_recibo As Integer = 0
    Public parametro_ultimo_deposito As String = ""
    Public parametro_detalle_deposito As String = ""
    Public parametro_periodo_liquidacion As String = ""
    Public parametro_fecha_liquidacion As DateTime
    Public parametro_fecha_pago As DateTime
    Public parametro_opcion_recibo As String = ""
    Public parametro_ultima_hoja As Integer = 0
    Public parametro_tipo_sueldo As String = ""


    Public parametro_banco As Integer = 0
    Public parametro_empresa As Integer = 0
    Public parametro_cuenta As Integer = 0
    Public parametro_id_banco As Integer = 0
    Public parametro_id_cuenta As Integer = 0
    Public parametro_fecha As DateTime
    Public parametro_id_iva As Integer = 0
    Public parametro_id_iva_old As Integer = 0
    Public parametro_nom_iva As String = ""
    Public parametro_iva_prn As String = ""
    Public parametro_periodo As DateTime
    Public parametro_nombre_cuenta As String = ""
    Public parametro_nombre_banco As String = ""
    Public parametro_Proveedor As Integer = 0
    Public parametro_nro_cheque As String = ""
    Public parametro_id_cliente As Integer = 0
    Public parametro_nro_transferencia As String = ""
    Public parametro_id_grupocampana As Integer = 0
    Public parametro_fac As Integer = 0
    Public parametro_sumainsumo As Integer = 0
    Public parametro_nro_sumalabor As Integer = 0
    Public parametro_fecha_transferencia As DateTime
    Public parametro_id_campana As Integer = 0
    Public parametro_fecha_stock As DateTime
    Public parametro_fecha_librado_desde As DateTime
    Public parametro_fecha_librado_hasta As DateTime
    Public parametro_fecha_pago_desde As DateTime
    Public parametro_fecha_pago_hasta As DateTime
    Public parametro_fecha_recibido_desde As DateTime
    Public parametro_fecha_recibido_hasta As DateTime
    Public parametro_fecha_acreditacion_desde As DateTime
    Public parametro_fecha_acreditacion_hasta As DateTime
    Public parametro_fecha_egreso_insumo As DateTime
    Public parametro_periodo_sueldo As String = ""
    Public parametro_letra_sueldo As String = ""
    Public parametro_proveedor_prn As Integer = 0
    Public parametro_nom_prov As String = ""
    Public parametro_sdo_ant As String = ""
    Public Banderaprintpantalla As String = ""
    Public bandera_imprime_cliente As Integer = 0
    Public parametro_cliente_prn As Integer = 0
    Public parametro_nom_cliente As String = ""
    Public parametro_saldo_anterior As Decimal = 0
    Public parametro_bandera_query_trasferencias As Integer = 0
    Public parametro_con_fecha As Boolean = False
    Public parametro_numero_cuenta As String = ""

    Public parametro_id_pago_cliente As String = ""
    ''    -----------------------------
    Public parametro_num_cuenta As String
    Public parametro_nom_banco As String
    ''----------------------

    'variables globales
    Public codigo_producto As String = ""

    Public parametro_cliente As String = ""

    Public PathAyuda As String
    Public PathReporte As String

    Public vgUsuarioAnterior As Integer
    Public vgCtrlagregado As Boolean
    Public vgyalogueado As Boolean


    Function CompletarCerosCodigo(ByVal strCadena As String) As String
        Select Case Len(strCadena)
            Case 1 : strCadena = "0000" + strCadena
            Case 2 : strCadena = "000" + strCadena
            Case 3 : strCadena = "00" + strCadena
            Case 4 : strCadena = "0" + strCadena
            Case 5 : strCadena = strCadena
        End Select

        Return strCadena
    End Function
    Function CompletarCeros(ByVal strCadena As String, ByVal intLargo As Integer) As String
        If intLargo = 4 Then
            Select Case Len(strCadena)
                Case 0 : strCadena = "0000" + strCadena
                Case 1 : strCadena = "000" + strCadena
                Case 2 : strCadena = "00" + strCadena
                Case 3 : strCadena = "0" + strCadena
            End Select
        End If
        If intLargo = 8 Then
            Select Case Len(strCadena)
                Case 0 : strCadena = "00000000" + strCadena
                Case 1 : strCadena = "0000000" + strCadena
                Case 2 : strCadena = "000000" + strCadena
                Case 3 : strCadena = "00000" + strCadena
                Case 4 : strCadena = "0000" + strCadena
                Case 5 : strCadena = "000" + strCadena
                Case 6 : strCadena = "00" + strCadena
                Case 7 : strCadena = "0" + strCadena
            End Select
        End If
        Return strCadena
    End Function

    Function CompletarCeros2(ByVal strCadena As String) As String

        Select Case Len(strCadena)
            Case 0 : strCadena = "000000000000" + strCadena
            Case 1 : strCadena = "00000000000" + strCadena
            Case 2 : strCadena = "0000000000" + strCadena
            Case 3 : strCadena = "000000000" + strCadena
            Case 4 : strCadena = "00000000" + strCadena
            Case 5 : strCadena = "0000000" + strCadena
            Case 6 : strCadena = "000000" + strCadena
            Case 7 : strCadena = "00000" + strCadena
            Case 8 : strCadena = "0000" + strCadena
            Case 9 : strCadena = "000" + strCadena
            Case 10 : strCadena = "00" + strCadena
            Case 11 : strCadena = "0" + strCadena
            Case 12 : strCadena = strCadena
        End Select

        Return strCadena
    End Function

    Public Function ControlarCampo(ByVal nombre_campo As String, ByVal dt As DataTable) As Boolean
        Dim Resultado As Boolean = False
        For Each column As DataColumn In dt.Columns
            If column.ColumnName = nombre_campo Then
                Resultado = True
                Exit For
            End If
        Next

        Return Resultado
    End Function

    Public Function RetornarCheck(ByVal valor_check As String) As Boolean
        If valor_check = "X" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function RetornarValor(ByVal valor_check As Boolean) As String
        If valor_check = True Then
            Return "X"
        Else
            Return ""
        End If
    End Function

    Public Function RetornarColor(ByVal valor_check As Boolean) As Color
        If valor_check = True Then
            Return Color.Red
        Else
            Return Color.White
        End If
    End Function


    Public Sub Errores(ByVal ex2 As Exception)
        Try
            With oLog_Error
                .Cargar()
                .Insertar()
                .numero = CStr(Err.Number)
                .mensaje = ex2.Message
                .origen = ex2.Source
                .descripcion = ex2.StackTrace
                .fecha = DateTime.Now
                .Guardar()
            End With
        Catch ex As Exception
        End Try
    End Sub


    Public Sub GenererPathProyecto(ByVal id_proyecto As Integer)
        Dim odt_hijos As New DataTable
        Dim odt_padre As New DataTable
        Dim odt As New DataTable
        Dim path_padre As String = ""

        odt_hijos = oProyecto.GetTree_Padre(id_proyecto)

        If odt_hijos.Rows.Count > 0 Then
            odt_padre = oProyecto.GetOne(id_proyecto)
            path_padre = odt_padre.Rows(0).Item("path").ToString()

            For Each row As DataRow In odt_hijos.Rows
                generarPathHijo(CInt(row("id_proyecto").ToString()), path_padre)

                odt = oProyecto.GetTree_Padre(CInt(row("id_proyecto").ToString()))

                If odt.Rows.Count > 0 Then
                    'SIGNIFICA QUE ES PADRE
                    GenererPathProyecto(CInt(row("id_proyecto").ToString()))

                End If

            Next
        End If


    End Sub

    Private Sub generarPathHijo(ByVal id_proyecto_hijo As Integer, ByVal path_padre As String)
        Dim odt As New DataTable

        Dim path_nuevo As String = ""
        Dim nombre_proyecto As String = ""

        odt = oProyecto.GetOne(id_proyecto_hijo) 'PROYECTO HIJO
        nombre_proyecto = odt.Rows(0).Item("nombre_proyecto").ToString()
        path_nuevo = path_padre + "-" + nombre_proyecto

        With oProyecto
            .Cargar()
            .Modificar(id_proyecto_hijo)
            .path = path_nuevo
            .Guardar()
        End With

    End Sub

End Module

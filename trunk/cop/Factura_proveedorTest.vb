Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Dececco



'''<summary>
'''Se trata de una clase de prueba para Factura_proveedor_entTest y se pretende que
'''contenga todas las pruebas unitarias Factura_proveedor_entTest. 
'''</summary>
<TestClass()> _
Public Class Factura_proveedorTest


   Private testContextInstance As TestContext

   '''<summary>
   '''Obtiene o establece el contexto de la prueba que proporciona
   '''la información y funcionalidad para la ejecución de pruebas actual. 
   '''</summary>
   Public Property TestContext() As TestContext
       Get
           Return testContextInstance
       End Get
       Set(ByVal value As TestContext) 
           testContextInstance = value
       End Set
   End Property

#Region "Atributos de prueba adicionales"
   '
   'Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas: 
   '
   'Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
   '<ClassInitialize()>  _
   'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext) 
   'End Sub
   '
   'Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
   '<ClassCleanup()>  _
   'Public Shared Sub MyClassCleanup()
   'End Sub
   '
   'Use TestInitialize para ejecutar código antes de ejecutar cada prueba
   '<TestInitialize()>  _
   'Public Sub MyTestInitialize()
   'End Sub
   '
   'Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
   '<TestCleanup()>  _
   'Public Sub MyTestCleanup()
   'End Sub
   '
#End Region


   '''<summary>
    '''Una prueba de Modificar
    '''</summary>
   <TestMethod()> _
   Public Sub ModificarFactura_proveedorTest()
       Dim target As Factura_proveedor_ent = New Factura_proveedor_ent ' TODO: Inicializar en un valor adecuado
       Dim expected As DataTable = Nothing ' TODO: Inicializar en un valor adecuado
       target.Truncate()
       target.InsertOne()
       target.Cargar()
       target.Modificar(1) 
       target.nombre_Factura_proveedor = "modificado"
       target.Guardar()

       Dim dt As DataTable = New DataTable
       dt = target.ConsultarTodo
       Assert.IsTrue(CBool(dt.Rows(0).Item("nombre_Factura_proveedor").ToString = "modificado"),"no: " & dt.Rows(0).Item("nombre_Factura_proveedor").ToString)
   End Sub

   '''<summary>
   '''Una prueba de Insertar
   '''</summary>
   <TestMethod()> _
   Public Sub InsertarFactura_proveedorTest()
       Dim target As Factura_proveedor_ent = New Factura_proveedor_ent ' TODO: Inicializar en un valor adecuado

       target.Truncate()
       target.InsertOne()
       target.Cargar()
       target.Insertar()
       target.nombre_Factura_proveedor = "prueba"
       target.Guardar()

       Dim dt As DataTable = New DataTable
       dt = target.ConsultarTodo

       Assert.IsTrue(dt.Rows.Count = 2, "son: " & dt.Rows.Count & " registros")
   End Sub

   '''<summary>
   '''Una prueba de GetOne
   '''</summary>
   <TestMethod()> _
   Public Sub GetOneFactura_proveedorTest()
       Dim target As Factura_proveedor_ent = New Factura_proveedor_ent ' TODO: Inicializar en un valor adecuado
       Dim id_Factura_proveedor As Integer = 1 ' TODO: Inicializar en un valor adecuado
       Dim expected As DataTable = Nothing ' TODO: Inicializar en un valor adecuado
       Dim actual As DataTable

       target.Truncate()
       target.InsertOne()

       actual = target.GetOne(id_Factura_proveedor)

       Assert.IsTrue(actual.Rows.Count = 1, "son: " & actual.Rows.Count & " registros")
   End Sub

   '''<summary>
   '''Una prueba de GetCmb
   '''</summary>
   <TestMethod()> _
   Public Sub GetCmbFactura_proveedorTest()
       Dim target As Factura_proveedor_ent = New Factura_proveedor_ent ' TODO: Inicializar en un valor adecuado
       Dim expected As DataTable = Nothing ' TODO: Inicializar en un valor adecuado
       Dim actual As DataTable

       target.Truncate()
       target.InsertOne()

       actual = target.GetCmb

       Assert.IsTrue(actual.Rows.Count = 1, "son: " & actual.Rows.Count & " registros")
   End Sub

   '''<summary>
   '''Una prueba de Exist
   '''</summary>
   <TestMethod()> _
   Public Sub ExistFactura_proveedorTest()
       Dim target As Factura_proveedor_ent = New Factura_proveedor_ent ' TODO: Inicializar en un valor adecuado
       Dim expected As Boolean = False ' TODO: Inicializar en un valor adecuado
       Dim actual As Boolean

       target.Truncate()
       target.InsertOne()

       target.Modificar(1) 
       target.nombre_Factura_proveedor = "prueba"
       target.Guardar()

       actual = target.Exist

       Assert.IsTrue(actual = True, "no: " & actual) 
   End Sub

   '''<summary>
   '''Una prueba de ConsultarTodo
   '''</summary>
   <TestMethod()> _
   Public Sub ConsultarTodoFactura_proveedorTest()
       Dim target As Factura_proveedor_ent = New Factura_proveedor_ent ' TODO: Inicializar en un valor adecuado
       Dim expected As DataTable = Nothing ' TODO: Inicializar en un valor adecuado
       Dim actual As DataTable

       target.Truncate()
       target.InsertOne()
       target.Cargar()
       target.Insertar()
       target.nombre_Factura_proveedor = "prueba"
       target.Guardar()

       actual = target.ConsultarTodo

       Assert.IsTrue(actual.Rows.Count = 2, "son: " & actual.Rows.Count & " registros")
   End Sub

   '''<summary>
   '''Una prueba de Buscar
   '''</summary>
   <TestMethod()> _
   Public Sub BuscarFactura_proveedorTest()
       Dim target As Factura_proveedor_ent = New Factura_proveedor_ent ' TODO: Inicializar en un valor adecuado
       Dim Nombre As String = "pru" ' TODO: Inicializar en un valor adecuado
       Dim expected As DataTable = Nothing ' TODO: Inicializar en un valor adecuado
       Dim actual As DataTable

       target.Truncate()
       target.InsertOne()
       target.Cargar()
       target.Insertar()
       target.nombre_Factura_proveedor = "prueba"
       target.Guardar()

       target.Insertar()
       target.nombre_Factura_proveedor = "prudente"
       target.Guardar()

       actual = target.Buscar(Nombre) 

       Assert.IsTrue(actual.Rows.Count = 2, "son: " & actual.Rows.Count & " registros")
   End Sub

   '''<summary>
   '''Una prueba de Borrar
   '''</summary>
   <TestMethod()> _
   Public Sub BorrarFactura_proveedorTest()
       Dim target As Factura_proveedor_ent = New Factura_proveedor_ent ' TODO: Inicializar en un valor adecuado
       Dim id_Factura_proveedor As Integer = 1 ' TODO: Inicializar en un valor adecuado
       Dim expected As DataTable = Nothing ' TODO: Inicializar en un valor adecuado
       'Dim actual As DataTable

       target.Truncate()
       target.InsertOne()
       target.Borrar(id_Factura_proveedor) 

       Dim dt As DataTable = New DataTable
       dt = target.GetOne(id_Factura_proveedor) 

       Assert.IsTrue(dt.Rows.Count = 0, "son: " & dt.Rows.Count & " registros")
   End Sub
End Class

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports EJEMPLOMVCUMG

Namespace Controllers
    Public Class PersonasController
        Inherits System.Web.Mvc.Controller

        Private db As New miPrimeraBDEntities

        ' GET: Personas
        Function Index() As ActionResult
            Dim personas = db.Personas.Include(Function(p) p.Profesion)
            Return View(personas.ToList())
        End Function

        ' GET: Personas/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim personas As Personas = db.Personas.Find(id)
            If IsNothing(personas) Then
                Return HttpNotFound()
            End If
            Return View(personas)
        End Function

        ' GET: Personas/Create
        Function Create() As ActionResult
            ViewBag.idProfesion = New SelectList(db.Profesion, "idProfesion", "nombreProfesion")
            Return View()
        End Function

        ' POST: Personas/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="idPersona,primerNombre,segundoNombre,apellidos,direccion,telefono,idProfesion")> ByVal personas As Personas) As ActionResult
            If ModelState.IsValid Then
                db.Personas.Add(personas)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.idProfesion = New SelectList(db.Profesion, "idProfesion", "nombreProfesion", personas.idProfesion)
            Return View(personas)
        End Function

        ' GET: Personas/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim personas As Personas = db.Personas.Find(id)
            If IsNothing(personas) Then
                Return HttpNotFound()
            End If
            ViewBag.idProfesion = New SelectList(db.Profesion, "idProfesion", "nombreProfesion", personas.idProfesion)
            Return View(personas)
        End Function

        ' POST: Personas/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="idPersona,primerNombre,segundoNombre,apellidos,direccion,telefono,idProfesion")> ByVal personas As Personas) As ActionResult
            If ModelState.IsValid Then
                db.Entry(personas).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.idProfesion = New SelectList(db.Profesion, "idProfesion", "nombreProfesion", personas.idProfesion)
            Return View(personas)
        End Function

        ' GET: Personas/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim personas As Personas = db.Personas.Find(id)
            If IsNothing(personas) Then
                Return HttpNotFound()
            End If
            Return View(personas)
        End Function

        ' POST: Personas/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim personas As Personas = db.Personas.Find(id)
            db.Personas.Remove(personas)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace

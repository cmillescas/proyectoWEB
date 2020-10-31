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
    Public Class ProfesionsController
        Inherits System.Web.Mvc.Controller

        Private db As New miPrimeraBDEntities

        ' GET: Profesions
        Function Index() As ActionResult
            Return View(db.Profesion.ToList())
        End Function

        ' GET: Profesions/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim profesion As Profesion = db.Profesion.Find(id)
            If IsNothing(profesion) Then
                Return HttpNotFound()
            End If
            Return View(profesion)
        End Function

        ' GET: Profesions/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Profesions/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="idProfesion,nombreProfesion")> ByVal profesion As Profesion) As ActionResult
            If ModelState.IsValid Then
                db.Profesion.Add(profesion)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(profesion)
        End Function

        ' GET: Profesions/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim profesion As Profesion = db.Profesion.Find(id)
            If IsNothing(profesion) Then
                Return HttpNotFound()
            End If
            Return View(profesion)
        End Function

        ' POST: Profesions/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="idProfesion,nombreProfesion")> ByVal profesion As Profesion) As ActionResult
            If ModelState.IsValid Then
                db.Entry(profesion).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(profesion)
        End Function

        ' GET: Profesions/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim profesion As Profesion = db.Profesion.Find(id)
            If IsNothing(profesion) Then
                Return HttpNotFound()
            End If
            Return View(profesion)
        End Function

        ' POST: Profesions/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim profesion As Profesion = db.Profesion.Find(id)
            db.Profesion.Remove(profesion)
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

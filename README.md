# ??? �gora � Plataforma de Gesti�n de Capacitaciones

![Estado](https://img.shields.io/badge/estado-en%20desarrollo-yellow) ![Versi�n](https://img.shields.io/badge/version-0.1.0-blue) ![Hecho por](https://img.shields.io/badge/2do%20A�o-Programaci�n-4CAF50)

�gora es un proyecto educativo desarrollado junto a estudiantes de 2.� a�o de Programaci�n. Su objetivo es brindar una plataforma integral para gestionar **capacitaciones** de una instituci�n educativa: desde la publicaci�n y la inscripci�n (online/presencial), hasta la **acreditaci�n**, **cobros** y **emisi�n de certificados**.

---

## ?? Objetivo del proyecto

Construir un sistema **claro, �gil y auditable** que permita organizar capacitaciones y sus participantes, ofreciendo:

* Un **flujo simple** de inscripci�n (para p�blico general, docentes y alumnos).
* **Control de cupos**, **costos diferenciados** por tipo de inscripci�n y **habilitaci�n/deshabilitaci�n** de inscripciones.
* **Acreditaci�n de asistencia** y **registro de pagos** con reportes e **impresi�n de certificados** (individual y masiva).
* **Reportes operativos** para mesa de acreditaci�n y administraci�n.

---

## ??? �ndice

* [Objetivo del proyecto](#-objetivo-del-proyecto)
* [Alcance y funcionalidades](#-alcance-y-funcionalidades)
* [Roles y reglas generales](#-roles-y-reglas-generales)
* [Flujos principales](#-flujos-principales)
* [Entidades clave](#-entidades-clave)
* [Reportes e impresiones](#-reportes-e-impresiones)
* [Hoja de ruta (Roadmap)](#-hoja-de-ruta-roadmap)
* [Estructura del repositorio (sugerida)](#-estructura-del-repositorio-sugerida)
* [C�mo contribuir](#-c�mo-contribuir)
* [Licencia](#-licencia)

---

## ? Alcance y funcionalidades

A continuaci�n se detallan los **requerimientos funcionales** priorizados para la primera versi�n:

1. ?? **Capacitaciones**

   * Alta, modificaci�n y eliminaci�n de **capacitaciones**.
   * Habilitar/Deshabilitar la **inscripci�n** por capacitaci�n.
   * Definir **cupo m�ximo**.
   * Definir **costos** por tipo de inscripci�n: p�blico general, docentes y alumnos.

2. ?? **Usuarios**

   * Alta, modificaci�n y eliminaci�n de **usuarios**.

3. ?? **Inscripci�n online**

   * Inscribirse a una capacitaci�n disponible.
   * La inscripci�n se **desactiva autom�ticamente** al completar el **cupo m�ximo**.
   * *(Futuro)* Carga de **comprobante de transferencia** para acreditar pago; validaci�n por un usuario autorizado.

4. ?? **Inscripci�n presencial**

   * Registro manual por personal autorizado.

5. ? **Acreditaci�n de asistencia**

   * Marcado de asistencia para cada inscripto.

6. ?? **Certificados**

   * Impresi�n de certificados para acreditados que abonaron (si aplica).
   * **Impresi�n masiva** por capacitaci�n e **individual** por asistente.
   * Si la capacitaci�n **no tiene costo**, se imprime a todo **acreditado**.
   * Rol **administrativo** puede **imprimir a todos** (pago contra entrega).

7. ?? **Pagos**

   * Pantalla espec�fica para **registraci�n de pagos** (monto, medio, fecha, observaciones).

8. ?? **Listado de inscriptos**

   * **Impresi�n** de inscriptos por capacitaci�n (para mesa de acreditaci�n manual).

9. ?? **Listado de acreditados**

   * **Impresi�n** con detalle de **si pagaron** y **forma de pago**.

10. ?? **Reporte de cobros**

    * **Impresi�n** de cobros por usuario y por capacitaci�n, con **detalle y totales** por forma de pago.

---

## ???????? Roles y reglas generales

* **P�blico en general / Docente / Alumno:** puede **inscribirse** online cuando est� habilitado y existan cupos.
* **Administrativo:** puede **gestionar inscripciones presenciales**, **registrar pagos**, **acreditar asistencia** y **emitir certificados** (individual/masivo).
* **Reglas destacadas:**

  * La **inscripci�n** depende de **habilitaci�n** y **cupo**.
  * La **emisi�n de certificados** requiere **asistencia acreditada** y, si corresponde, **pago registrado**.

---

## ?? Flujos principales

1. **Publicar capacitaci�n**

   1. Crear capacitaci�n ? 2) Definir cupo y costos ? 3) Habilitar inscripciones.

2. **Inscripci�n online**

   1. Usuario elige capacitaci�n ? 2) Completa datos ? 3) Sistema valida cupo ? 4) Registro de inscripci�n.

3. **Inscripci�n presencial**

   1. Administrativo busca o crea usuario ? 2) Registra inscripci�n ? 3) Entrega comprobante.

4. **Acreditaci�n de asistencia**

   1. Lista de inscriptos ? 2) Marcar presente/ausente ? 3) Guardar acreditaci�n.

5. **Registro de pagos**

   1. Seleccionar inscripto ? 2) Registrar medio/monto/fecha ? 3) Asociar a capacitaci�n.

6. **Emisi�n de certificados**

   * **Individual**: verificar requisitos ? generar e imprimir.
   * **Masivo**: filtrar por capacitaci�n ? validar requisitos ? imprimir lote.

---

## ?? Entidades clave

| Entidad          | Descripci�n breve                                                                                                   |
| ---------------- | ------------------------------------------------------------------------------------------------------------------- |
| **Capacitaci�n** | T�tulo, descripci�n, fechas, **cupo m�ximo**, estado de inscripci�n (habilitada/inhabilitada), **costos por tipo**. |
| **Usuario**      | Datos personales, tipo: **p�blico**, **docente**, **alumno**, **administrativo**.                                   |
| **Inscripci�n**  | Usuario ? Capacitaci�n, estado (activa/cancelada), origen (**online/presencial**).                                  |
| **Asistencia**   | Registro por inscrito (acreditado / no acreditado).                                                                 |
| **Pago**         | Monto, **forma de pago**, fecha, referencia (comprobante), vinculado a Inscripci�n/Capacitaci�n.                    |
| **Certificado**  | Emisi�n individual/masiva para **acreditados** (y con pago si corresponde).                                         |

---

## ??? Reportes e impresiones

* **Inscriptos por capacitaci�n** (para mesa de acreditaci�n).
* **Acreditados por capacitaci�n** con estado de pago y forma de pago.
* **Cobros** por usuario y capacitaci�n, con **detalles y totales** por forma de pago.
* **Certificados**: emisi�n **individual** y **masiva**.

---

## ??? Hoja de ruta (Roadmap)

* [ ] **MVP**: ABM de capacitaciones y usuarios, inscripci�n online/presencial, acreditaci�n, pagos, reportes b�sicos y emisi�n de certificados.
* [ ] **Evidencia de pago (3.2)**: carga de imagen de transferencia + circuito de **validaci�n** por administrativo.
* [ ] **Mejoras UX**: filtros avanzados, b�squeda r�pida, exportaci�n a CSV/PDF.
* [ ] **Permisos granulares** por rol y auditor�a de acciones.
* [ ] **Notificaciones** (email/whatsapp) para confirmaciones y recordatorios.

---

## ?? Estructura del repositorio (sugerida)

```
/docs/                 # Documentaci�n funcional/t�cnica, decisiones y diagramas
/frontend/             # App web (por definir stack)
 /...                  
/backend/              # API/servicios (por definir stack)
 /...                  
/infrastructure/       # Scripts de despliegue, Docker, CI/CD
/.github/workflows/    # Pipelines (si corresponde)
README.md
LICENSE
```

> ?? **Sugerencia did�ctica:** mantener en `/docs` la **trazabilidad** entre requerimientos y pantallas/endpoints, y anotar decisiones (ADR) para aprender de la arquitectura del proyecto.

---

## ?? C�mo contribuir

1. Crea una rama con el formato `feature/descripcion-corta` o `fix/descripcion-corta`.
2. Acompa�a tus cambios con **descripci�n clara** y, cuando aplique, **capturas** o **gif**.
3. Relaciona tu PR con el requerimiento funcional correspondiente (ej.: �RF-6 Certificados�).
4. Pide **code review** a otro/a compa�ero/a y a la c�tedra antes de mergear.
5. Mant�n el estilo de c�digo consistente y agrega tests cuando sea posible.

---

## ?? Licencia

Este proyecto se distribuye bajo la licencia **MIT** (o la que la c�tedra defina). Incluye el archivo `LICENSE` en el repositorio.

---

### ?? Contacto

Proyecto **�gora** � 2.� A�o Programaci�n
Si ten�s dudas, sugerencias o encontr�s un bug, abr� un **Issue** y describ� claramente el caso.

---

> *�Lo que no se mide, no se mejora.�* � �gora prioriza la **claridad operativa** y la **trazabilidad** para que cada decisi�n y funcionalidad se pueda ense�ar, aprender y evolucionar.
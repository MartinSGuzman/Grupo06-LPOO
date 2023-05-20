# RAMA NICO TP2 TP3
CREACION DE BASE DE DATOS

usuario admin: nicoa 123
usuario operador: nicoo 123
usuario auditor: nicoau 123

# TABLAS

> Cliente
 - id int PK, dni varchar50, name, lastname, address, os_cuit, carnet_number
     - Second nested list item
> ObraSocial
 - id int PK, os_number, os_razon, os_address, os_phone <- varchar50
  - 3	1944	MEDIFE	BELGRANO	990298
> Producto
 - id int PK, key_product, category, description <- varchar50 , price decimal
> Roles
 - rol_id int, rol_desc varchar50
  - 1	Administrador
  - 2	Operador
  - 3	Auditor
> Usuarios
  - user_id int, user_username, user_password, username <-varchar 50, rol_id int
  - 1	nicoa	123	 	NULL  1
  - 2	nicoo	123	 	NULL  2
  - 3	nicoau	123	 	NULL  3
> Venta
- id int, date datetime, dni_customer varchar 50

> VentaDetalle
- id int, key_sale, key_product <- varchar50, price, cant, total <-decimal
#!/bin/bash
echo Escriba usuario
read user 
echo Password
read password 
echo Escriba Base de Datos
read database
mysql -u "$user" -p"$password" -D "$database" -e "SELECT * FROM persons"
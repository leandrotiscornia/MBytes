#!/bin/bash
#Parámetros de conexión
echo Indique los parámetros de conexión:
echo Escriba HOST
read host 
echo Escriba USER
read user 
echo Escriba PASSWORD
read password
echo Escriba DATABASE 
read database  
sql_host= $host
slq_usuario= $user
sql_password= $password
sql_database= $database
#Monta los parámetros
sql_args=” -h $sql_host -u $slq_usuario -p $sql_password -D $sql_database -s -e ”
mysql sql_args = "SELECT * FROM persons"

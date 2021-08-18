function operarador()
{
echo Bienvenido al Operador del Sistema de Chat Institucional
echo 1-Gestión
echo 2-Logs
echo 3-Back Up
echo 0-Salir
}
operador
while true
	read opcion
	case $opcion in
		1) gestion
			;;
		2) logs
			;;
		3) backUp
			;;
		0) salir
			;;
		*)
			echo Opción Incorrecta
			;;
		
function gestion()
{
	clear
	echo 1-Alta
	echo 2-Baja
	echo 3-Modificación
	read opcionGestion
	case $opcionGestion in
		1)
		clear	
		echo Usted esta en Gestión-Alta	
		echo 1-Usuarios
		echo 2-Asignaturas 
		echo 3-Grupos
		echo 4-Volver al Menu de Gest
		read opcionAlta
		case $opcionAlta in
			1) altaUsuarios.sh
					;;
			2) altaAsignaturas.sh
					;;
			3) altaGrupos.sh
					;;

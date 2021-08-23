#!/bin/bash
function operarador()
{
	echo Bienvenido al Operador del Sistema de Chat Institucional
	echo 1-Gestión
	echo 2-Logs
	echo 3-Back Up
	echo 0-Salir
}

function gestion()
{
	echo 1- Alta
	echo 2- Baja
	echo 3- Modificación
	echo 4- Volver a Menú Operador
	echo 0- Salir del Operador
}

function salir()
{
	S = "S"
	s = "s"
	N = "N"
	n = "n"
	read opcionSalir -p "Esta seguro que desea salir del operador ? S/s = SI - N/n = NO "
	if [[$opcionSalir = $S || $opcionSalir = $s]]
	then
		break
		echo Operador Finalizado
	else   
		echo No ha seleccionado ninguna de la opciones anteriores
		operador
	fi

	if [[$opcionSalir = $N || $opcionSalir = $n]]
	then
		operador
		echo Hola de nuevo!
	else
		echo No ha seleccionado ninguna de la opciones anteriores
	fi	
}

operador
while true
do	
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
	esac	
		

	gestion	
		read opcionGestion
		case $opcionGestion in
			1)
			clear	
			echo Usted esta en ALTA	
			echo 1- Alta Usuarios
			echo 2- Alta Materias 
			echo 3- Alta Grupos
			echo 4-Volver a Menú de Gestión
			echo 5- Volver a Menú Operador
			echo 0- Salir del Operador
			read opcionAlta
			case $opcionAlta in
				1) clear
			   	   	sh /Alta/altaUsuarios.sh
								;;
				2) clear
			   		sh altaMaterias.sh
								;;
				3) clear
			   		sh altaGrupos.sh
								;;
				4) clear
			   		gestion	
			   					;;
				5)clear
			  		operador
			  					;;
				0)salir
								;;
				*) echo Opción Incorrecta
								;;
							
			esac
			;;
			2)
			clear
			echo Usted está en BAJA
			echo 1- Baja Usuarios
			echo 2- Baja Materias
			echo 3- Baja Grupos
			echo 4- Volver a Menú Gestión
			echo 5- Volver a Menú Operador
			echo 0- Salir del Operador
			read opcionBaja
			case $opcionBaja in
				1)clear
			  		sh bajaUsuarios.sh
			  				;;
				2) clear
			   		sh bajaMaterias.sh
			   		;;
				3) clear
			   		sh bajaGrupos.sh
			   				;;
				4) 
			   		gestion
			   				;;
				5) clear
			    	operador
			    			;;
				0) salir
				        	;;
				*) echo Opción Incorrecta
				        	;;
			esac
			;;
			3)
			clear
			echo Usted está en MODIFICACIÓN
			echo 1- Modicación Usuarios
			echo 2- Modifación Materias
			echo 3- Modificación Grupos
			echo 4- Volver a Menú Gestión
			echo 5- Volver a Menú Operador
			echo 0- Salir del Operador
			read opcionModificacion
			case $opcionModificacion in
				1) clear
			   	sh modificacionUsuarios.sh
			   		 				;;
				2) clear
			   	sh modificacionMaterias.sh
			   						;;
				3) clear
			   	sh modificacionGrupos.sh
			   						;;
				4) gestion
				        			;;
				5) clear
			   	operador
			                		;;
				0) salir
				        			;;
		        *) echo Opción Incorrecta
				        			;;
			esac
			;;
			4)
			clear
			operador
				;;
			5) salir
				;;
		*) echo Opción Incorrecta 
			;;	
	esac
	;;
	

done
	echo Finalizo Operador

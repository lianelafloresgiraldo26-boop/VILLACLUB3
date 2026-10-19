Algoritmo Sin_titulo
	Definir codigo, nombres, dni, manzana, lote Como Cadena
    Definir codigos, nombresLista, dniLista, manzanas, lotes Como Cadena
    Definir seleccion, cantidad, i, posicion Como Entero
    Definir repetido Como Logico
	
    Dimension codigos[100]
    Dimension nombresLista[100]
    Dimension dniLista[100]
    Dimension manzanas[100]
    Dimension lotes[100]
	
    cantidad <- 0
    seleccion <- 0
	
    Repetir
        Escribir ""
        Escribir "=================================="
        Escribir "     SISTEMA VILLA CLUB 3"
        Escribir "     GESTION DE RESIDENTES"
        Escribir "=================================="
        Escribir "1. Registrar residente"
        Escribir "2. Buscar residente"
        Escribir "3. Modificar residente"
        Escribir "4. Limpiar datos ingresados"
        Escribir "5. Salir"
        Escribir "Seleccione una opcion:"
        Leer seleccion
		
        Segun seleccion Hacer
			
            1:
                Si cantidad < 100 Entonces
                    Escribir "Ingrese el codigo:"
                    Leer codigo
					
                    repetido <- Falso
					
                    Si cantidad > 0 Entonces
						Para i <- 1 Hasta cantidad Hacer
							Si codigos[i] = codigo Entonces
								repetido <- Verdaero 
							FinSi
						FinPara
                        FinSi
					
                    Si repetido = Verdadero Entonces
                        Escribir "El codigo ya esta registrado."
                    SiNo
                        Escribir "Ingrese los nombres:"
                        Leer nombres
						
                        Escribir "Ingrese el DNI:"
                        Leer dni
						
                        Escribir "Ingrese la manzana:"
                        Leer manzana
						
                        Escribir "Ingrese el lote:"
                        Leer lote
						
                        cantidad <- cantidad + 1
						
                        codigos[cantidad] <- codigo
                        nombresLista[cantidad] <- nombres
                        dniLista[cantidad] <- dni
                        manzanas[cantidad] <- manzana
                        lotes[cantidad] <- lote
						
                        Escribir "Residente registrado correctamente."
                    FinSi
                SiNo
                    Escribir "No hay espacio para mas registros."
                FinSi
				
            2:
                Escribir "Ingrese el codigo que desea buscar:"
                Leer codigo
				
                posicion <- 0
				
                Para i <- 1 Hasta cantidad Hacer
                    Si codigos[i] = codigo Entonces
                        posicion <- i
                    FinSi
                FinPara
				
                Si posicion > 0 Entonces
                    Escribir "Residente encontrado:"
                    Escribir "Codigo: ", codigos[posicion]
                    Escribir "Nombres: ", nombresLista[posicion]
                    Escribir "DNI: ", dniLista[posicion]
                    Escribir "Manzana: ", manzanas[posicion]
                    Escribir "Lote: ", lotes[posicion]
                SiNo
                    Escribir "No se encontro el residente."
                FinSi
				
            3:
                Escribir "Ingrese el codigo que desea modificar:"
                Leer codigo
				
                posicion <- 0
				
                Para i <- 1 Hasta cantidad Hacer
                    Si codigos[i] = codigo Entonces
                        posicion <- i
                    FinSi
                FinPara
				
                Si posicion > 0 Entonces
                    Escribir "Ingrese los nuevos nombres:"
                    Leer nombres
					
                    Escribir "Ingrese el nuevo DNI:"
                    Leer dni
					
                    Escribir "Ingrese la nueva manzana:"
                    Leer manzana
					
                    Escribir "Ingrese el nuevo lote:"
                    Leer lote
					
                    nombresLista[posicion] <- nombres
                    dniLista[posicion] <- dni
                    manzanas[posicion] <- manzana
                    lotes[posicion] <- lote
					
                    Escribir "Residente modificado correctamente."
                SiNo
                    Escribir "No se encontro el residente."
                FinSi
				
            4:
                codigo <- ""
                nombres <- ""
                dni <- ""
                manzana <- ""
                lote <- ""
				
                Escribir "Los campos de ingreso han sido limpiados."
                Escribir "Los registros guardados se mantienen."
				
            5:
                Escribir "Gracias por utilizar el sistema."
				
            De Otro Modo:
                Escribir "Opcion no valida. Intente nuevamente."
				
        FinSegun
		
    Hasta Que seleccion = 5
FinAlgoritmo
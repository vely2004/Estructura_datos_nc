class Estudiante:
    def __init__(self, id, nombres, apellidos, direccion, telefonos):
        self.id = id
        self.nombres = nombres
        self.apellidos = apellidos
        self.direccion = direccion
        self.telefonos = telefonos

    def mostrar_datos(self):
        print("=== Registro del Estudiante ===")
        print(f"ID: {self.id}")
        print(f"Nombres: {self.nombres}")
        print(f"Apellidos: {self.apellidos}")
        print(f"Dirección: {self.direccion}")
        print("Teléfonos:")
        for tel in self.telefonos:
            print(f" - {tel}")

# Captura de datos desde consola
telefonos = []
print("Ingrese los datos del estudiante:")

id = int(input("ID: "))
nombres = input("Nombres: ")
apellidos = input("Apellidos: ")
direccion = input("Dirección: ")

for i in range(3):
    tel = input(f"Teléfono {i+1}: ")
    telefonos.append(tel)

estudiante = Estudiante(id, nombres, apellidos, direccion, telefonos)
print()
estudiante.mostrar_datos()

SELECT * 
from PHC.Puesto 
INNER JOIN PHC.Nivel ON PHC.Nivel.idNivel = PHC.Puesto.idNivel
INNER JOIN PHC.Departamento ON PHC.Puesto.idDepartamento = PHC.Departamento.idDepartamento;

SELECT PHC.Nivel.nombre as 'NombreNivel'
from PHC.Puesto
INNER JOIN PHC.Nivel ON PHC.Nivel.idNivel = PHC.Puesto.idNivel;
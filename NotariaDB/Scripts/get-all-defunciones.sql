USE notariadb;

SELECT d.id,
	   relateduser_id,
	   d.name,
       d.surname,
       'N' AS sex,
       dead_date,
       reg_date,
       CONCAT(m.name, ' ', m.surname) AS medic,
       p.city AS city,
       p.department AS department
FROM defunciones d, medicos m, places p
WHERE d.medic_id = m.id AND
	  d.place_id = p.place_id;

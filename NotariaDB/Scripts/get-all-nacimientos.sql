USE notariadb;

SELECT nuip,
		'',
        n.name AS "NOMBRE",
		CONCAT(surname1,' ',surname2) AS "APELLIDO",
        sex,
		b.name AS bloodtype,
        CONCAT(p.city,', ', p.department) AS place,
        birth_date,
        DATE_FORMAT(reg_date, '%Y-%m-%d') AS reg_date,
        a.name AS attachtype,
        attach_description,
        dad_id,
        mom_id,
        witness1_id,
        witness2_id,
        relateduser_id,
        CONCAT(t.name, ' ', t.surname) AS notary,
        fileroute
FROM nacimientos n, bloodtypes b, nac_attaches a, places p, notarios t
WHERE n.bloodtype_id = b.bloodtype_id
	AND n.attach_id = a.attach_id
	AND n.place_id = p.place_id
    AND n.notary_id = t.id;
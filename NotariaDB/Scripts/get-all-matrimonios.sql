USE notariadb;

SELECT m.id,
	   name1,
       surname1,
       relateduser1_id,
       name2,
       surname2,
       relateduser2_id,
       CONCAT(p.city,', ', p.department) AS place,
       weeding_date,
       reg_date
FROM matrimonios m,
	 places p,
     notarios n,
     mat_attaches t
WHERE m.place_id = p.place_id AND
	  m.notary_id = n.id AND
      m.attach_id = t.attach_id;
using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotariaDB.Database.Migrations
{
    public partial class Seeders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "bloodtypes",
                columns: new[] { "bloodtype_id", "name" },
                values: new object[,]
                {
                    { 1, "A+" },
                    { 2, "A-" },
                    { 3, "B+" },
                    { 4, "B-" },
                    { 5, "O+" },
                    { 6, "O-" },
                    { 7, "AB+" },
                    { 8, "AB-" }
                });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 922, "SAN CARLOS DE GUAROA" },
                    { 921, "RESTREPO" },
                    { 920, "PUERTO RICO" },
                    { 919, "PUERTO LLERAS" },
                    { 918, "PUERTO LÓPEZ" },
                    { 917, "PUERTO GAITÁN" },
                    { 913, "LA MACARENA" },
                    { 915, "LEJANÍAS" },
                    { 914, "LA URIBE" },
                    { 923, "SAN JUAN DE ARAMA" },
                    { 912, "MESETAS" },
                    { 911, "MAPIRIPÁN" },
                    { 916, "PUERTO CONCORDIA" },
                    { 924, "SAN JUANITO" },
                    { 928, "ALBÁN (SAN JOSÉ)" },
                    { 926, "VISTAHERMOSA" },
                    { 927, "PASTO" },
                    { 910, "GUAMAL" },
                    { 929, "ALDANA" },
                    { 930, "ANCUYÁ" },
                    { 931, "ARBOLEDA (BERRUECOS)" },
                    { 932, "BARBACOAS" },
                    { 933, "BELÉN" },
                    { 934, "BUESACO" },
                    { 935, "COLÓN (GÉNOVA)" },
                    { 936, "CONSACÁ" },
                    { 937, "CONTADERO" },
                    { 938, "CÓRDOBA" },
                    { 939, "CUASPUD (CARLOSAMA)" },
                    { 925, "SAN MARTÍN" },
                    { 909, "GRANADA" },
                    { 905, "EL CALVARIO" },
                    { 907, "EL DORADO" },
                    { 877, "ARIGUANÍ (EL DIFÍCIL)" },
                    { 878, "CERRO SAN ANTONIO" },
                    { 879, "CHIVOLO" },
                    { 880, "CIÉNAGA" },
                    { 881, "EL BANCO" },
                    { 882, "EL PIÑÓN" },
                    { 883, "EL RETÉN" },
                    { 884, "FUNDACIÓN" },
                    { 885, "GUAMAL" },
                    { 886, "PEDRAZA" },
                    { 887, "PIJIÑO DEL CARMEN" },
                    { 888, "PIVIJAY" },
                    { 889, "PLATO" },
                    { 890, "PUBLOVIEJO" },
                    { 908, "FUENTE DE ORO" },
                    { 891, "REMOLINO" },
                    { 893, "SAN SEBASTIÁN DE BUUENAVISTA" },
                    { 894, "SAN ZENÓN" },
                    { 895, "SANTA ANA" },
                    { 896, "SITIONUEVO" },
                    { 897, "TENERIFE" },
                    { 898, "VILLAVICENCIO" },
                    { 899, "ACACIAS" },
                    { 900, "BARRANCA DE UPÍA" },
                    { 901, "CABUYARO" },
                    { 902, "CASTILLA LA NUEVA" },
                    { 903, "CUBARRAL" },
                    { 904, "CUMARAL" },
                    { 940, "CUMBAL" },
                    { 906, "EL CASTILLO" },
                    { 892, "SALAMINA" },
                    { 941, "CUMBITARÁ" },
                    { 945, "EL TABLÓN" },
                    { 943, "EL CHARCO" },
                    { 978, "SAN LORENZO" },
                    { 979, "SAN PABLO" },
                    { 980, "SAN PEDRO DE CARTAGO" },
                    { 981, "SANTA BÁRBARA (ISCUANDÉ)" },
                    { 982, "SANTA CRUZ (GUACHÁVEZ)" },
                    { 983, "SAPUYÉS" },
                    { 984, "TAMINANGO" },
                    { 985, "TANGUA" },
                    { 986, "TUMACO" },
                    { 987, "TÚQUERRES" },
                    { 988, "YACUANQUER" },
                    { 989, "CÚCUTA" },
                    { 990, "ABREGO" },
                    { 991, "ARBOLEDAS" },
                    { 992, "BOCHALEMA" },
                    { 993, "BUCARASICA" },
                    { 994, "CÁCOTA" },
                    { 995, "CÁCHIRA" },
                    { 996, "CHINÁCOTA" },
                    { 997, "CHITAGÁ" },
                    { 998, "CONVENCIÓN" },
                    { 999, "CUCUTILLA" },
                    { 1000, "DURANIA" },
                    { 1001, "EL CARMEN" },
                    { 1002, "EL TARRA" },
                    { 1003, "EL ZULIA" },
                    { 1004, "GRAMALOTE" },
                    { 1005, "HACARÍ" },
                    { 1006, "HERRÁN" },
                    { 977, "SAN BERNARDO" },
                    { 976, "SANDONÁ" },
                    { 975, "SAMANIEGO" },
                    { 974, "ROBERTO PAYÁN (SAN JOSÉ)" },
                    { 944, "EL ROSARIO" },
                    { 876, "ARACATACA" },
                    { 946, "EL TAMBO" },
                    { 947, "FUNES" },
                    { 948, "GUACHUCAL" },
                    { 949, "GUAITARILLA" },
                    { 950, "GUALMATÁN" },
                    { 951, "ILES" },
                    { 952, "IMÚES" },
                    { 953, "IPIALES" },
                    { 954, "LA CRUZ" },
                    { 955, "LA FLORIDA" },
                    { 956, "LA LLANADA" },
                    { 957, "LA TOLA" },
                    { 942, "CHACHAGÜI" },
                    { 958, "LA UNIÓN" },
                    { 960, "LINARES" },
                    { 961, "LOS ANDES (SOTOMAYOR)" },
                    { 962, "MAGÜÍ (PAYÁN)" },
                    { 963, "MALLAMA (PIEDRANCHA)" },
                    { 964, "MOSQUERA" },
                    { 965, "OLAYA" },
                    { 966, "OSPINA" },
                    { 967, "FRANCISCO PIZARRO" },
                    { 968, "POLICARPA" },
                    { 969, "POTOSÍ" },
                    { 970, "PROVIDENCIA" },
                    { 971, "PUERRES" },
                    { 972, "PUPIALES" },
                    { 973, "RICAURTE" },
                    { 959, "LEIVA" },
                    { 875, "SANTA MARTA" },
                    { 871, "SAN JUAN DEL CESAR" },
                    { 873, "URUMITA" },
                    { 776, "TAUSA" },
                    { 777, "TENA" },
                    { 778, "TENJO" },
                    { 779, "TIBACUY" },
                    { 780, "TIBIRITÁ" },
                    { 781, "TOCAIMA" },
                    { 782, "TOCANCIPÁ" },
                    { 783, "TOPAIPÍ" },
                    { 784, "UBALÁ" },
                    { 785, "UBAQUE" },
                    { 786, "UBATÉ" },
                    { 787, "UNE" },
                    { 788, "ÚTICA" },
                    { 789, "VERGARA" },
                    { 790, "VIANÍ" },
                    { 791, "VILLAGÓMEZ" },
                    { 792, "VILLAPINZÓN" },
                    { 793, "VILLETA" },
                    { 794, "VIOTÁ" },
                    { 795, "YACOPÍ" },
                    { 796, "ZIPACÓN" },
                    { 797, "ZIPAQUIRÁ" },
                    { 798, "QUIBDÓ" },
                    { 799, "ACANDÍ" },
                    { 800, "ALTO BAUDÓ (PIE DE PATO)" },
                    { 801, "ATRATO (YUTO)" },
                    { 802, "BAGADÓ" },
                    { 803, "BAHÍA SOLANO (MÚTIS)" },
                    { 804, "BAJO BAUDÓ (PIZARRO)" },
                    { 775, "TABIO" },
                    { 774, "SUTATAUSA" },
                    { 773, "SUSA" },
                    { 772, "SUPATÁ" },
                    { 741, "NEMOCÓN" },
                    { 742, "NILO" },
                    { 743, "NIMAIMA" },
                    { 744, "NOCAIMA" },
                    { 745, "VENECIA (OSPINA PÉREZ)" },
                    { 746, "PACHO" },
                    { 747, "PAIME" },
                    { 748, "PANDI" },
                    { 749, "PARATEBUENO" },
                    { 750, "PASCA" },
                    { 751, "PUERTO SALGAR" },
                    { 752, "PULÍ" },
                    { 753, "QUEBRADANEGRA" },
                    { 754, "QUETAME" },
                    { 805, "BOJAYÁ (BELLAVISTA)" },
                    { 756, "RAFAEL" },
                    { 758, "SAN ANTONIO DE TEQUENDAMA" },
                    { 759, "SAN BERNARDO" },
                    { 760, "SAN CAYETANO" },
                    { 761, "SAN FRANCISCO" },
                    { 762, "SAN JUAN DE RIOSECO" },
                    { 763, "SASAIMA" },
                    { 764, "SESQUILÉ" },
                    { 765, "SIBATE" },
                    { 766, "SILVANIA" },
                    { 767, "SIMIJACA" },
                    { 768, "SOACHA" },
                    { 769, "SOPÓ" },
                    { 770, "SUBACHOQUE" },
                    { 771, "SUESCA" },
                    { 757, "RICAURTE" },
                    { 806, "CANTÓN DE SAN PABLO" },
                    { 807, "CONDOTO" },
                    { 808, "EL CARMEN" },
                    { 843, "NÁTAGA" },
                    { 844, "OPORAPA" },
                    { 845, "PAICOL" },
                    { 846, "PALERMO" },
                    { 847, "PALESTINA" },
                    { 848, "PITAL" },
                    { 849, "PITALITO" },
                    { 850, "RIVERA" },
                    { 851, "SALADOBLANCO" },
                    { 852, "SAN AGUSTÍN" },
                    { 853, "SANTA MARÍA" },
                    { 854, "SUAZÁ" },
                    { 855, "TARQUI" },
                    { 856, "TESALIA" },
                    { 842, "LA PLATA" },
                    { 857, "TELLO" },
                    { 859, "TIMANÁ" },
                    { 860, "VILLAVIEJA" },
                    { 861, "YAGUARÁ" },
                    { 862, "RIOHACHA" },
                    { 863, "BARRANCAS" },
                    { 864, "DIBULLA" },
                    { 865, "DISTRACCIÓN" },
                    { 866, "EL MOLINO" },
                    { 867, "FONSECA" },
                    { 868, "HATONUEVO" },
                    { 869, "MAICAO" },
                    { 870, "MANAURE" },
                    { 1007, "LABATECA" },
                    { 872, "URIBÍA" },
                    { 858, "TERUEL" },
                    { 874, "VILLANUEVA" },
                    { 841, "LA ARGENTINA" },
                    { 839, "IQUIRA" },
                    { 809, "EL LITORAL DE SAN JUAN" },
                    { 810, "ITSMINA" },
                    { 811, "JURADÓ" },
                    { 812, "LLORÓ" },
                    { 813, "NÓVITA" },
                    { 814, "NUQUÍ" },
                    { 815, "RIOSUCIO" },
                    { 816, "SAN JOSÉ DEL PALMAR" },
                    { 817, "SIPÍ" },
                    { 818, "TADÓ" },
                    { 819, "UNGUÍA" },
                    { 820, "PUERTO INÍRIDA" },
                    { 821, "SAN JOSÉ DEL GUAVIARE" },
                    { 822, "CALAMAR" },
                    { 840, "ISNOS" },
                    { 823, "EL RETORNO" },
                    { 825, "NEIVA" },
                    { 826, "ACEVEDO" },
                    { 827, "AGRADO" },
                    { 828, "AIPE" },
                    { 829, "ALGECIRAS" },
                    { 830, "ALTAMIRA" },
                    { 831, "BARAYA" },
                    { 832, "CAMPOALEGRE" },
                    { 833, "COLOMBIA" },
                    { 834, "ELÍAS" },
                    { 835, "GARZÓN" },
                    { 836, "GIGANTE" },
                    { 837, "GUADALUPE" },
                    { 838, "HOBO" },
                    { 824, "MIRAFLORES" },
                    { 1008, "LA ESPERANZA" },
                    { 1012, "MUTISCUA" },
                    { 1010, "LOS PATIOS" },
                    { 1180, "TOLUVIEJO" },
                    { 1181, "IBAGUÉ" },
                    { 1182, "ALPUJARRA" },
                    { 1183, "ALVARADO" },
                    { 1184, "AMBALEMA" },
                    { 1185, "ANZÓATEGUI" },
                    { 1186, "ARMERO (GUAYABAL)" },
                    { 1187, "ATACO" },
                    { 1188, "CAJAMARCA" },
                    { 1189, "CARMEN DE APICALÁ" },
                    { 1190, "CASABIANCA" },
                    { 1191, "CHAPARRAL" },
                    { 1192, "COELLO" },
                    { 1193, "COYAIMA" },
                    { 1194, "CUNDAY" },
                    { 1195, "DOLORES" },
                    { 1196, "ESPINAL" },
                    { 1197, "FALÁN" },
                    { 1198, "FLANDES" },
                    { 1199, "FRESNO" },
                    { 1200, "GUAMO" },
                    { 1201, "HERVEO" },
                    { 1202, "HONDA" },
                    { 1203, "ICONONZO" },
                    { 1204, "LÉRIDA" },
                    { 1205, "LÍBANO" },
                    { 1206, "MARIQUITA" },
                    { 1207, "MELGAR" },
                    { 1208, "MURILLO" },
                    { 1179, "TOLÚ" },
                    { 1178, "SUCRE" },
                    { 1177, "SINCÉ" },
                    { 1176, "SAN PEDRO" },
                    { 1146, "SIMACOTA" },
                    { 1147, "SOCORRO" },
                    { 1148, "SUAITA" },
                    { 1149, "SUCRE" },
                    { 1150, "SURATÁ" },
                    { 1151, "TONA" },
                    { 1152, "VALLE DE SAN JOSÉ" },
                    { 1153, "VÉLEZ" },
                    { 1154, "VETAS" },
                    { 1155, "VILLANUEVA" },
                    { 1156, "ZAPATOCA" },
                    { 1157, "SINCELEJO" },
                    { 1158, "BUENAVISTA" },
                    { 1159, "CAIMITO" },
                    { 1209, "NATAGAIMA" },
                    { 1160, "COLOSO (RICAURTE)" },
                    { 1162, "CHALÁN" },
                    { 1163, "GALERAS (NUEVA GRANADA)" },
                    { 1164, "GUARANDÁ" },
                    { 1165, "LA UNIÓN" },
                    { 1166, "LOS PALMITOS" },
                    { 1167, "MAJAGUAL" },
                    { 1168, "MORROA" },
                    { 1169, "OVEJAS" },
                    { 1170, "PALMITO" },
                    { 1171, "SAMPUÉS" },
                    { 1172, "SAN BENITO ABAD" },
                    { 1173, "SAN JUAN DE BETULIA" },
                    { 1174, "SAN MARCOS" },
                    { 1175, "SAN ONOFRE" },
                    { 1161, "COROZAL" },
                    { 1210, "ORTEGA" },
                    { 1211, "PALOCABILDO" },
                    { 1212, "PIEDRAS" },
                    { 1247, "GINEBRA" },
                    { 1248, "GUACARÍ" },
                    { 1249, "JAMUNDÍ" },
                    { 1250, "LA CUMBRE" },
                    { 1251, "LA UNIÓN" },
                    { 1252, "LA VICTORIA" },
                    { 1253, "OBANDO" },
                    { 1254, "PALMIRA" },
                    { 1255, "PRADERA" },
                    { 1256, "RESTREPO" },
                    { 1257, "RIOFRÍO" },
                    { 1258, "ROLDANILLO" },
                    { 1259, "SAN PEDRO" },
                    { 1260, "SEVILLA" },
                    { 1246, "FLORIDA" },
                    { 1261, "TORO" },
                    { 1263, "TULUÁ" },
                    { 1264, "ULLOA" },
                    { 1265, "VERSALLES" },
                    { 1266, "VIJES" },
                    { 1267, "YOTOCO" },
                    { 1268, "YUMBO" },
                    { 1269, "ZARZAL" },
                    { 1270, "MITÚ" },
                    { 1271, "CARURÚ" },
                    { 1272, "TATAMÁ" },
                    { 1273, "PUERTO CARREÑO" },
                    { 1274, "LA PRIMAVERA" },
                    { 1275, "SANTA ROSALIA" },
                    { 1276, "CUMARIBO" },
                    { 1262, "TRUJILLO" },
                    { 1145, "SANTA HELENA DEL OPÓN" },
                    { 1245, "EL DOVIO" },
                    { 1243, "EL CAIRO" },
                    { 1213, "PLANADAS" },
                    { 1214, "PRADO" },
                    { 1215, "PURIFICACIÓN" },
                    { 1216, "RIOBLANCO" },
                    { 1217, "RONCESVALLES" },
                    { 1218, "ROVIRA" },
                    { 1219, "SALDAÑA" },
                    { 1220, "SAN ANTONIO" },
                    { 1221, "SAN LUIS" },
                    { 1222, "SANTA ISABEL" },
                    { 1223, "SUÁREZ" },
                    { 1224, "VALLE DE SAN JUAN" },
                    { 1225, "VENADILLO" },
                    { 1226, "VILLAHERMOSA" },
                    { 1244, "EL CERRITO" },
                    { 1227, "VILLARRICA" },
                    { 1229, "ALCALÁ" },
                    { 1230, "ANDALUCÍA" },
                    { 1231, "ANSERMANUEVO" },
                    { 1232, "ARGELIA" },
                    { 1233, "BOLÍVAR" },
                    { 1234, "BUENAVENTURA" },
                    { 1235, "BUGA" },
                    { 1236, "BUGALAGRANDE" },
                    { 1237, "CAICEDONIA" },
                    { 1238, "CALIMA (DARIÉN)" },
                    { 1239, "CANDELARIA" },
                    { 1240, "CARTAGO" },
                    { 1241, "DAGUA" },
                    { 1242, "EL ÁGUILA" },
                    { 1228, "CALI" },
                    { 1009, "LA PLAYA" },
                    { 1144, "SANTA BÁRBARA" },
                    { 1142, "SAN MIGUEL" },
                    { 1045, "CIRCASIA" },
                    { 1046, "CÓRDOBA" },
                    { 1047, "FILANDIA" },
                    { 1048, "GÉNOVA" },
                    { 1049, "LA TEBAIDA" },
                    { 1050, "MONTENEGRO" },
                    { 1051, "PIJAO" },
                    { 1052, "QUIMBAYA" },
                    { 1053, "SALENTO" },
                    { 1054, "PEREIRA" },
                    { 1055, "APÍA" },
                    { 1056, "BALBOA" },
                    { 1057, "BELÉN DE UMBRÍA" },
                    { 1058, "DOS QUEBRADAS" },
                    { 1059, "GUÁTICA" },
                    { 1060, "LA CELIA" },
                    { 1061, "LA VIRGINIA" },
                    { 1062, "MARSELLA" },
                    { 1063, "MISTRATÓ" },
                    { 1064, "PUEBLO RICO" },
                    { 1065, "QUINCHIA" },
                    { 1066, "SANTA ROSA DE CABAL" },
                    { 1067, "SANTUARIO" },
                    { 1068, "SAN ANDRÉS" },
                    { 1069, "PROVIDENCIA" },
                    { 1070, "BUCARAMANGA" },
                    { 1071, "AGUADA" },
                    { 1072, "ALBANIA" },
                    { 1073, "ARATOCA" },
                    { 1044, "CALARCÁ" },
                    { 1043, "BUENAVISTA" },
                    { 1042, "ARMENIA" },
                    { 1041, "VILLA GARZÓN" },
                    { 1011, "LOURDES" },
                    { 740, "NARIÑO" },
                    { 1013, "OCAÑA" },
                    { 1014, "PAMPLONA" },
                    { 1015, "PAMPLONITA" },
                    { 1016, "PUERTO SANTANDER" },
                    { 1017, "RAGONVALIA" },
                    { 1018, "SALAZAR" },
                    { 1019, "SAN CALIXTO" },
                    { 1020, "SAN CAYETANO" },
                    { 1021, "SANTIAGO" },
                    { 1022, "SARDINATA" },
                    { 1023, "SILOS" },
                    { 1024, "TEORAMA" },
                    { 1074, "BARBOSA" },
                    { 1025, "TIBÚ" },
                    { 1027, "VILLACARO" },
                    { 1028, "VILLA DEL ROSARIO" },
                    { 1029, "MOCOA" },
                    { 1030, "COLÓN" },
                    { 1031, "ORITO" },
                    { 1032, "PUERTO ASÍS" },
                    { 1033, "PUERTO CAICEDO" },
                    { 1034, "PUERTO GUZMÁN" },
                    { 1035, "PUERTO LEGUÍZAMO" },
                    { 1036, "SIBUNDOY" },
                    { 1037, "SAN FRANCISCO" },
                    { 1038, "SAN MIGUEL" },
                    { 1039, "SANTIAGO" },
                    { 1040, "VILLA GAMUEZ (LA HORMIGA)" },
                    { 1026, "TOLEDO" },
                    { 1075, "BARICHARA" },
                    { 1076, "BARRANCABERMEJA" },
                    { 1077, "BETULIA" },
                    { 1112, "JESÚS MARÍA" },
                    { 1113, "JORDÁN" },
                    { 1114, "LA BELLEZA" },
                    { 1115, "LANDÁZURI" },
                    { 1116, "LA PAZ" },
                    { 1117, "LEBRIJA" },
                    { 1118, "LOS SANTOS" },
                    { 1119, "MACARAVITA" },
                    { 1120, "MÁLAGA" },
                    { 1121, "MATANZA" },
                    { 1122, "MOGOTES" },
                    { 1123, "MOLAGAVITA" },
                    { 1124, "OCAMONTE" },
                    { 1125, "OIBA" },
                    { 1111, "HATO" },
                    { 1126, "ONZÁGA" },
                    { 1128, "PALMAS DEL SOCORRO" },
                    { 1129, "PÁRAMO" },
                    { 1130, "PIE DE CUESTA" },
                    { 1131, "PINCHOTE" },
                    { 1132, "PUENTE NACIONAL" },
                    { 1133, "PUERTO PARRA" },
                    { 1134, "PUERTO WILCHES" },
                    { 1135, "RIONEGRO" },
                    { 1136, "SABANA DE TORRES" },
                    { 1137, "SAN ANDRÉS" },
                    { 1138, "SAN BENITO" },
                    { 1139, "SAN GIL" },
                    { 1140, "SAN JOAQUÍN" },
                    { 1141, "SAN JOSÉ DE MIRANDA" },
                    { 1127, "PALMAR" },
                    { 1143, "SAN VICENTE DE CHUCURÍ" },
                    { 1110, "GUEPSA" },
                    { 1108, "GUAPOTÁ" },
                    { 1078, "BOLÍVAR" },
                    { 1079, "CABRERA" },
                    { 1080, "CALIFORNIA" },
                    { 1081, "CAPITANEJO" },
                    { 1082, "CARCASÍ" },
                    { 1083, "CEPITÁ" },
                    { 1084, "CERRITO" },
                    { 1085, "CHARALÁ" },
                    { 1086, "CHARTA" },
                    { 1087, "CHIMA" },
                    { 1088, "CHIPATÁ" },
                    { 1089, "CIMITARRA" },
                    { 1090, "CONCEPCIÓN" },
                    { 1091, "CONFINES" },
                    { 1109, "GUAVATA" },
                    { 1092, "CONTRATACIÓN" },
                    { 1094, "CURITÍ" },
                    { 1095, "EL CARMEN" },
                    { 1096, "EL GUACAMAYO" },
                    { 1097, "EL PEÑÓN" },
                    { 1098, "EL PLAYÓN" },
                    { 1099, "ENCINO" },
                    { 1100, "ENCISO" },
                    { 1101, "FLORIÁN" },
                    { 1102, "FLORIDABLANCA" },
                    { 1103, "GALÁN" },
                    { 1104, "GÁMBITA" },
                    { 1105, "GIRÓN" },
                    { 1106, "GUACA" },
                    { 1107, "GUADALUPE" },
                    { 1093, "COROMORO" },
                    { 739, "MOSQUERA" },
                    { 755, "QUIPILE" },
                    { 737, "MANTA" },
                    { 370, "CÓRDOBA" },
                    { 371, "CLEMENCIA" },
                    { 372, "EL CARMEN DE BOLÍVAR" },
                    { 373, "EL GUAMO" },
                    { 374, "EL PEÑÓN" },
                    { 375, "HATILLO DE LOBA" },
                    { 376, "MAGANGUE" },
                    { 377, "MAHATES" },
                    { 378, "MARGARITA" },
                    { 379, "MARÍA LA BAJA" },
                    { 380, "MONTECRISTO" },
                    { 381, "MOMPÓS" },
                    { 382, "MORALES" },
                    { 383, "PINILLOS" },
                    { 384, "REGIDOR" },
                    { 385, "RÍO VIEJO" },
                    { 386, "SAN CRISTÓBAL" },
                    { 387, "SAN ESTANISLAO" },
                    { 388, "SAN FERNANDO" },
                    { 389, "SAN JACINTO" },
                    { 390, "SAN JACINTO DEL CAUCA" },
                    { 391, "SAN JUAN NEPOMUCENO" },
                    { 392, "SAN MARTÍN DE LOBA" },
                    { 393, "SAN PABLO" },
                    { 394, "SANTA CATALINA" },
                    { 395, "SANTA ROSA" },
                    { 396, "SANTA ROSA DEL SUR" },
                    { 397, "SIMITÍ" },
                    { 398, "SOPLAVIENTO" },
                    { 369, "CICUTO" },
                    { 368, "CANTAGALLO" },
                    { 367, "CALAMAR" },
                    { 366, "BARRANCO DE LOBA" },
                    { 336, "TAME" },
                    { 337, "BARRANQUILLA" },
                    { 338, "BARANOA" },
                    { 339, "CAMPO DE LA CRUZ" },
                    { 340, "CANDELARIA" },
                    { 341, "GALAPA" },
                    { 342, "JUAN DE ACOSTA" },
                    { 343, "LURUACO" },
                    { 344, "MALAMBO" },
                    { 345, "MANATÍ" },
                    { 346, "PALMAR DE VARELA" },
                    { 347, "PIOJÓ" },
                    { 348, "POLONUEVO" },
                    { 349, "PONEDERA" },
                    { 399, "TALAIGUA NUEVO" },
                    { 350, "PUERTO COLOMBIA" },
                    { 352, "SABANAGRANDE" },
                    { 353, "SABANALARGA" },
                    { 354, "SANTA LUCÍA" },
                    { 355, "SANTO TOMÁS" },
                    { 356, "SOLEDAD" },
                    { 357, "SUÁN" },
                    { 358, "TUBARÁ" },
                    { 359, "USIACURÍ" },
                    { 360, "CARTAGENA" },
                    { 361, "ACHÍ" },
                    { 362, "ALTOS DEL ROSARIO" },
                    { 363, "ARENAL" },
                    { 364, "ARJONA" },
                    { 365, "ARROYOHONDO" },
                    { 351, "REPELÓN" },
                    { 400, "TIQUISIO (PUERTO RICO)" },
                    { 401, "TURBACO" },
                    { 402, "TURBANÁ" },
                    { 437, "EL COCUY" },
                    { 438, "EL ESPINO" },
                    { 439, "FIRAVITOBA" },
                    { 440, "FLORESTA" },
                    { 441, "GACHANTIVÁ" },
                    { 442, "GÁMEZA" },
                    { 443, "GARAGOA" },
                    { 444, "GUACAMAYAS" },
                    { 445, "GUATEQUE" },
                    { 446, "GUAYATÁ" },
                    { 447, "GUICÁN" },
                    { 448, "IZA" },
                    { 738, "MEDINA" },
                    { 450, "JERICÓ" },
                    { 436, "DUITAMA" },
                    { 451, "LABRANZAGRANDE" },
                    { 453, "LA VICTORIA" },
                    { 454, "LA UBITA" },
                    { 455, "VILLA DE LEYVA" },
                    { 456, "MACANAL" },
                    { 457, "MARIPÍ" },
                    { 458, "MIRAFLORES" },
                    { 459, "MONGUA" },
                    { 460, "MONGUÍ" },
                    { 461, "MONIQUIRÁ" },
                    { 462, "MOTAVITA" },
                    { 463, "MUZO" },
                    { 464, "NOBSA" },
                    { 465, "NUEVO COLÓN" },
                    { 466, "OICATÁ" },
                    { 452, "LA CAPILLA" },
                    { 335, "SARAVENA" },
                    { 435, "CHIVOR" },
                    { 433, "CUITIVA" },
                    { 403, "VILLANUEVA" },
                    { 404, "ZAMBRANO" },
                    { 405, "TUNJA" },
                    { 406, "ALMEIDA" },
                    { 407, "AQUITANIA" },
                    { 408, "ARCABUCO" },
                    { 409, "BELÉN" },
                    { 410, "BERBEO" },
                    { 411, "BETEITIVA" },
                    { 412, "BOAVITA" },
                    { 413, "BOYACÁ" },
                    { 414, "BRISEÑO" },
                    { 415, "BUENAVISTA" },
                    { 416, "BUSBANZÁ" },
                    { 434, "CHÍQUIZA" },
                    { 417, "CALDAS" },
                    { 419, "CERINZA" },
                    { 420, "CHINAVITA" },
                    { 421, "CHIQUINQUIRÁ" },
                    { 422, "CHISCAS" },
                    { 423, "CHITA" },
                    { 424, "CHITARANQUE" },
                    { 425, "CHIVATÁ" },
                    { 426, "CIÉNAGA" },
                    { 427, "CÓMBITA" },
                    { 428, "COPER" },
                    { 429, "CORRALES" },
                    { 430, "COVARACHIA" },
                    { 431, "CUBAR" },
                    { 432, "CUCAITA" },
                    { 418, "CAMPOHERMOSO" },
                    { 467, "OTANCHE" },
                    { 334, "PUERTO RONDÓN" },
                    { 332, "PUERTO RONDÓN" },
                    { 235, "CARMEN DE VIBORAL" },
                    { 236, "CAROLINA" },
                    { 237, "CAUCASIA" },
                    { 238, "CHIGORODÓ" },
                    { 239, "CISNEROS" },
                    { 240, "COCORNÁ" },
                    { 241, "CONCEPCIÓN" },
                    { 242, "CONCORDIA" },
                    { 243, "COPACABANA" },
                    { 244, "DABEIBA" },
                    { 245, "DON MATÍAS" },
                    { 246, "EBÉJICO" },
                    { 247, "EL BAGRE" },
                    { 248, "ENTRERRÍOS" },
                    { 249, "ENVIGADO" },
                    { 250, "FREDONIA" },
                    { 251, "FRONTINO" },
                    { 252, "GIRALDO" },
                    { 253, "GIRARDOTA" },
                    { 254, "GÓMEZ PLATA" },
                    { 255, "GRANADA" },
                    { 256, "GUADALUPE" },
                    { 257, "GUARNE" },
                    { 258, "GUATAPÉ" },
                    { 259, "HELICONIA" },
                    { 260, "HISPANIA" },
                    { 261, "ITAGÜÍ" },
                    { 262, "ITUANGO" },
                    { 263, "JARDÍN" },
                    { 234, "CAREPA" },
                    { 233, "CARAMANTA" },
                    { 232, "CARACOLÍ" },
                    { 231, "CAÑASGORDAS" },
                    { 201, "PUERTO NARIÑO" },
                    { 202, "LETICIA" },
                    { 203, "MEDELLÍN" },
                    { 204, "ABEJORRAL" },
                    { 205, "ABRIAQUI" },
                    { 206, "ALEJANDRÍA" },
                    { 207, "AMAGÁ" },
                    { 208, "AMALFI" },
                    { 209, "ANDES" },
                    { 210, "ANGELÓPOLIS" },
                    { 211, "ANGOSTURA" },
                    { 212, "ANORÍ" },
                    { 213, "ANTIOQUIA" },
                    { 214, "ANZÁ" },
                    { 264, "JERICÓ" },
                    { 215, "APARTADÓ" },
                    { 217, "ARGELIA" },
                    { 218, "ARMENIA" },
                    { 219, "BARBOSA" },
                    { 220, "BELMIRA" },
                    { 221, "BELLO" },
                    { 222, "BETANIA" },
                    { 223, "BETULIA" },
                    { 224, "BOLÍVAR" },
                    { 225, "BRISEÑO" },
                    { 226, "BURITICÁ" },
                    { 227, "CÁCERES" },
                    { 228, "CAICEDO" },
                    { 229, "CALDAS" },
                    { 230, "CAMPAMENTO" },
                    { 216, "ARBOLETES" },
                    { 265, "LA CEJA" },
                    { 266, "LA ESTRELLA" },
                    { 267, "LA PINTADA" },
                    { 302, "SAN VICENTE" },
                    { 303, "SANTA BÁRBARA" },
                    { 304, "SANTA ROSA DE OSOS" },
                    { 305, "SANTO DOMINGO" },
                    { 306, "SANTUARIO" },
                    { 307, "SEGOVIA" },
                    { 308, "SONSÓN" },
                    { 309, "SOPETRÁN" },
                    { 310, "TÁMESIS" },
                    { 311, "TARAZÁ" },
                    { 312, "TARSO" },
                    { 313, "TITIRIBÍ" },
                    { 314, "TOLEDO" },
                    { 315, "TURBO" },
                    { 301, "SAN ROQUE" },
                    { 316, "URAMITA" },
                    { 318, "VALDIVIA" },
                    { 319, "VALPARAÍSO" },
                    { 320, "VEGACHÍ" },
                    { 321, "VENECIA" },
                    { 322, "VIGÍA DEL FUERTE" },
                    { 323, "YALÍ" },
                    { 324, "YARUMAL" },
                    { 325, "YOLOMBÓ" },
                    { 326, "YONDÓ (CASABE)" },
                    { 327, "ZARAGOZA" },
                    { 328, "ARAUCA" },
                    { 329, "ARAUQUITA" },
                    { 330, "CRAVO NORTE" },
                    { 331, "FORTUL" },
                    { 317, "URRAO" },
                    { 333, "FORTUL" },
                    { 300, "SAN RAFAEL" },
                    { 298, "SAN PEDRO" },
                    { 268, "LA UNIÓN" },
                    { 269, "LIBORINA" },
                    { 270, "MACEO" },
                    { 271, "MARINILLA" },
                    { 272, "MONTEBELLO" },
                    { 273, "MURINDÓ" },
                    { 274, "MUTATÁ" },
                    { 275, "NARIÑO" },
                    { 276, "NECOCLÍ" },
                    { 277, "NECHÍ" },
                    { 278, "OLAYA" },
                    { 279, "PEÑOL" },
                    { 280, "PEQUE" },
                    { 281, "PUEBLORRICO" },
                    { 299, "SAN PEDRO DE URABÁ" },
                    { 282, "PUERTO BERRÍO" },
                    { 284, "PUERTO TRIUNFO" },
                    { 285, "REMEDIOS" },
                    { 286, "RETIRO" },
                    { 287, "RIONEGRO" },
                    { 288, "SABANALARGA" },
                    { 289, "SABANETA" },
                    { 290, "SALGAR" },
                    { 291, "SAN ANDRÉS" },
                    { 292, "SAN CARLOS" },
                    { 293, "SAN FRANCISCO" },
                    { 294, "SAN JERÓNIMO" },
                    { 295, "SAN JOSÉ DE MONTAÑA" },
                    { 296, "SAN JUAN DE URABÁ" },
                    { 297, "SAN LUIS" },
                    { 283, "PUERTO NARE" },
                    { 468, "PACHAVITA" },
                    { 449, "JENESANO" },
                    { 470, "PAIPA" },
                    { 640, "GONZÁLEZ" },
                    { 641, "LA GLORIA" },
                    { 642, "LA JAGUA DE IBIRICO" },
                    { 643, "MANAURE BALCÓN CESAR" },
                    { 644, "PAILITAS" },
                    { 645, "PELAYA" },
                    { 646, "PUEBLO BELLO" },
                    { 647, "RÍO DE ORO" },
                    { 648, "LA PAZ (ROBLES)" },
                    { 649, "SAN ALBERTO" },
                    { 650, "SAN DIEGO" },
                    { 651, "SAN MARTÍN" },
                    { 652, "TAMALAMEQUE" },
                    { 653, "MONTERÍA" },
                    { 654, "AYAPEL" },
                    { 655, "BUENAVISTA" },
                    { 656, "CANALETE" },
                    { 657, "CERETÉ" },
                    { 658, "CHIMA" },
                    { 659, "CHINÚ" },
                    { 660, "CIÉNAGA DE ORO" },
                    { 661, "COTORRA" },
                    { 662, "LA APARTADA (FRONTERA)" },
                    { 663, "LORICA" },
                    { 664, "LOS CÓRDOBAS" },
                    { 665, "MOMIL" },
                    { 666, "MONTELÍBANO" },
                    { 667, "MONITOS" },
                    { 668, "PLANETA RICA" },
                    { 639, "GAMARRA" },
                    { 638, "EL PASO" },
                    { 637, "EL COPEY" },
                    { 636, "CURUMANÍ" },
                    { 606, "LÓPEZ (MICAY)" },
                    { 607, "MERCADERES" },
                    { 608, "MIRANDA" },
                    { 609, "MORALES" },
                    { 610, "PADILLA" },
                    { 611, "PÁEZ (BELALCAZAR)" },
                    { 612, "PATÍA (EL BORDO)" },
                    { 613, "PIAMONTE" },
                    { 614, "PIENDAMÓ" },
                    { 615, "PUERTO TEJADA" },
                    { 616, "PURACÉ (COCONUCO)" },
                    { 617, "ROSAS" },
                    { 618, "SAN SEBASTIÁN" },
                    { 619, "SANTANDER DE QUILICHAO" },
                    { 669, "PUEBLO NUEVO" },
                    { 620, "SANTA ROSA" },
                    { 622, "SOTARÁ (PAISPAMBA)" },
                    { 623, "SUÁREZ" },
                    { 469, "PÁEZ" },
                    { 625, "TIMBIQUÍ" },
                    { 626, "TORIBÍO" },
                    { 627, "TOTORO" },
                    { 628, "VALLEDUPAR" },
                    { 629, "AGUACHICA" },
                    { 630, "AGUSTÍN CODAZZI" },
                    { 631, "ASTREA" },
                    { 632, "BECERRIL" },
                    { 633, "BOSCONIA" },
                    { 634, "CHIMICHAGUA" },
                    { 635, "CHIRIGUANÁ" },
                    { 621, "SILVIA" },
                    { 670, "PUERTO ESCONDIDO" },
                    { 671, "PUERTO LIBERTADOR" },
                    { 672, "PURÍSIMA" },
                    { 707, "FACATATIVÁ" },
                    { 708, "FÓMEQUE" },
                    { 709, "FOSCA" },
                    { 710, "FUNZA" },
                    { 711, "FÚQUENE" },
                    { 712, "FUSAGASUGÁ" },
                    { 713, "GACHALÁ" },
                    { 714, "GACHANCIPÁ" },
                    { 715, "GACHETÁ" },
                    { 716, "GAMA" },
                    { 717, "GIRARDOT" },
                    { 718, "GRANADA" },
                    { 719, "GUACHETÁ" },
                    { 720, "GUADUAS" },
                    { 706, "EL ROSAL" },
                    { 721, "GUASCA" },
                    { 723, "GUATAVITA" },
                    { 724, "GUAYABAL DE SÍQUIMA" },
                    { 725, "GUAYABETAL" },
                    { 726, "GUTIÉRREZ" },
                    { 727, "JERUSALÉN" },
                    { 728, "JUNÍN" },
                    { 729, "LA CALERA" },
                    { 730, "LA MESA" },
                    { 731, "LA PALMA" },
                    { 732, "LA PEÑA" },
                    { 733, "LA VEGA" },
                    { 734, "LENGUAZAQUE" },
                    { 735, "MACHETÁ" },
                    { 736, "MADRID" },
                    { 722, "GUATAQUÍ" },
                    { 605, "LA VEGA" },
                    { 705, "EL PEÑÓN" },
                    { 703, "CUCUNUBÁ" },
                    { 673, "SAHAGÚN" },
                    { 674, "SAN ANDRÉS SOTAVENTO" },
                    { 675, "SAN ANTERO" },
                    { 676, "SAN BERNARDO DEL VIENTO" },
                    { 677, "SAN CARLOS" },
                    { 678, "SAN PELAYO" },
                    { 679, "TIERRALTA" },
                    { 680, "VALENCIA" },
                    { 681, "SANTAFÉ DE BOGOTÁ" },
                    { 682, "AGUA DE DIOS" },
                    { 683, "ALBÁN" },
                    { 684, "ANAPOIMA" },
                    { 685, "ANOLAIMA" },
                    { 686, "ARBELÁEZ" },
                    { 704, "EL COLEGIO" },
                    { 687, "BELTRÁN" },
                    { 689, "BOJACÁ" },
                    { 690, "CABRERA" },
                    { 691, "CACHIPAY" },
                    { 692, "CAJICÁ" },
                    { 693, "CAPARRAPÍ" },
                    { 694, "CÁQUEZA" },
                    { 695, "CARMEN DE CARUPA" },
                    { 696, "CHAGUANÍ" },
                    { 697, "CHÍA" },
                    { 698, "CHIPAQUE" },
                    { 699, "CHOACHÍ" },
                    { 700, "CHOCONTÁ" },
                    { 701, "COGUA" },
                    { 702, "COTA" },
                    { 688, "BITUIMA" },
                    { 604, "LA SIERRA" },
                    { 624, "TIMBÍO" },
                    { 602, "INZÁ" },
                    { 505, "SOTAQUIRÁ" },
                    { 506, "SORACÁ" },
                    { 507, "SUSACÓN" },
                    { 508, "SUTAMARCHÁN" },
                    { 509, "SUTATENZA" },
                    { 510, "TASCO" },
                    { 511, "TENZA" },
                    { 512, "TIBANÁ" },
                    { 513, "TIBASOSA" },
                    { 514, "TINJACÁ" },
                    { 603, "JAMBALÓ" },
                    { 516, "TOCA" },
                    { 517, "TOGUÍ" },
                    { 518, "TÓPAGA" },
                    { 519, "TOTA" },
                    { 520, "TUNUNGUA" },
                    { 521, "TURMEQUÉ" },
                    { 522, "TUTA" },
                    { 523, "TUTAZÁ" },
                    { 524, "ÚMBITA" },
                    { 525, "VENTAQUEMADA" },
                    { 526, "VIRACACHÁ" },
                    { 527, "ZETAQUIRÁ" },
                    { 528, "MANIZALES" },
                    { 529, "AGUADAS" },
                    { 530, "ANSERMA" },
                    { 531, "ARANZAZU" },
                    { 532, "BELALCÁZAR" },
                    { 533, "CHINCHINA" },
                    { 504, "SORA" },
                    { 503, "SOMONDOCO" },
                    { 502, "SOGAMOSO" },
                    { 501, "SOCHA" },
                    { 471, "PAJARITO" },
                    { 472, "PANQUEBA" },
                    { 473, "PAUNA" },
                    { 474, "PAYA" },
                    { 475, "PAZ DE RÍO" },
                    { 476, "PESCA" },
                    { 477, "PISVA" },
                    { 478, "PUERTO BOYACÁ" },
                    { 479, "QUÍPAMA" },
                    { 480, "RAMIQUIRÍ" },
                    { 481, "RÁQUIRA" },
                    { 482, "RONDÓN" },
                    { 483, "SABOYÁ" },
                    { 484, "SÁCHICA" },
                    { 534, "FILADELFIA" }
                });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 485, "SAMACÁ" },
                    { 487, "SAN JOSÉ DE PARE" },
                    { 488, "SAN LUIS DE GACENO" },
                    { 489, "SAN MATEO" },
                    { 490, "SAN MIGUEL DE SEMA" },
                    { 491, "SAN PABLO DE BORBUR" },
                    { 492, "SANTANA" },
                    { 493, "SANTA MARÍA" },
                    { 494, "SANTA ROSA DE VITERBO" },
                    { 495, "SANTA SOFÍA" },
                    { 496, "SATIVANORTE" },
                    { 497, "SATIVASUR" },
                    { 498, "SIACHOQUE" },
                    { 499, "SOATÁ" },
                    { 500, "SOCOTÁ" },
                    { 486, "SAN EDUARDO" },
                    { 535, "LA DORADA" },
                    { 515, "TIPACOQUE" },
                    { 537, "MANZANARES" },
                    { 572, "CHAMEZA" },
                    { 573, "HATO COROZAL" },
                    { 574, "LA SALINA" },
                    { 575, "MANÍ" },
                    { 576, "MONTERREY" },
                    { 577, "NUNCHÍA" },
                    { 578, "OROCUÉ" },
                    { 579, "PAZ DE ARIPORO" },
                    { 580, "PORE" },
                    { 581, "RECETOR" },
                    { 582, "SABALARGA" },
                    { 583, "SÁCAMA" },
                    { 584, "SAN LUIS DE PALENQUE" },
                    { 585, "TÁMARA" },
                    { 571, "AGUAZUL" },
                    { 586, "TAURAMENA" },
                    { 588, "VILLANUEVA" },
                    { 536, "LA MERCED" },
                    { 590, "ALMAGUER" },
                    { 591, "ARGELIA" },
                    { 592, "BALBOA" },
                    { 593, "BOLÍVAR" },
                    { 594, "BUENOS AIRES" },
                    { 595, "CAJIBÍO" },
                    { 596, "CALDONO" },
                    { 597, "CALOTO" },
                    { 598, "CORINTO" },
                    { 599, "EL TAMBO" },
                    { 600, "FLORENCIA" },
                    { 601, "GUAPI" },
                    { 587, "TRINIDAD" },
                    { 570, "YOPAL" },
                    { 589, "POPAYÁN" },
                    { 568, "SOLITA" },
                    { 569, "VALPARAÍSO" },
                    { 538, "MARMATO" },
                    { 539, "MARQUETALIA" },
                    { 540, "MARULANDA" },
                    { 541, "NEIRA" },
                    { 542, "PÁCORA" },
                    { 543, "PALESTINA" },
                    { 544, "PENSILVANIA" },
                    { 545, "RIOSUCIO" },
                    { 547, "SALAMINA" },
                    { 548, "SAMANÁ" },
                    { 549, "SAN JOSÉ" },
                    { 550, "SUPÍA" },
                    { 551, "VICTORIA" },
                    { 552, "VILLAMARÍA" },
                    { 546, "RISARALDA" },
                    { 553, "VITERBO" },
                    { 567, "SOLANO" },
                    { 565, "SAN JOSÉ DEL FRAGUA" },
                    { 564, "PUERTO RICO" },
                    { 563, "MORELIA" },
                    { 562, "MILÁN" },
                    { 561, "LA MONTAÑITA" },
                    { 560, "EL PAUJIL" },
                    { 566, "SAN VICENTE DEL CAGUÁN" },
                    { 554, "FLORENCIA" },
                    { 558, "CURILLO" },
                    { 557, "CARTAGENA DEL CHAIRÁ" },
                    { 556, "BELÉN DE LOS ANDAQUÍES" },
                    { 555, "ALBANIA" },
                    { 559, "EL DONCELLO" }
                });

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 19, "META" },
                    { 20, "NARIÑO" },
                    { 21, "NORTE DE SANTANDER" },
                    { 22, "PUTUMAYO" },
                    { 23, "QUINDÍO" },
                    { 24, "RISARALDA" },
                    { 18, "MAGDALENA" },
                    { 26, "SANTANDER" },
                    { 27, "SUCRE" },
                    { 28, "TOLIMA" },
                    { 29, "VALLE" },
                    { 30, "VAUPÉS" },
                    { 31, "VICHADA" },
                    { 25, "SAN ANDRÉS" },
                    { 17, "LA GUAJIRA" },
                    { 5, "BOYACÁ" },
                    { 15, "GUAVIARE" },
                    { 1, "AMAZONAS" },
                    { 16, "HUILA" },
                    { 3, "ARAUCA" },
                    { 4, "ATLÁNTICO" },
                    { 6, "CALDAS" },
                    { 7, "CAQUETÁ" },
                    { 2, "ANTIOQUIA" },
                    { 9, "CAUCA" },
                    { 10, "CESAR" },
                    { 11, "CÓRDOBA" },
                    { 12, "CUNDINAMARCA" },
                    { 13, "CHOCÓ" },
                    { 14, "GUAINÍA" },
                    { 8, "CASANARE" }
                });

            migrationBuilder.InsertData(
                table: "doctypes",
                columns: new[] { "doctype_id", "description" },
                values: new object[,]
                {
                    { 3, "PASAPORTE" },
                    { 2, "TARJETA DE IDENTIDAD" },
                    { 1, "CÉDULA" }
                });

            migrationBuilder.InsertData(
                table: "mat_attaches",
                columns: new[] { "attach_id", "name" },
                values: new object[,]
                {
                    { 1, "ACTA RELIGIOSA" },
                    { 2, "ESCRITURA DE PROTOCOLIZACIÓN" }
                });

            migrationBuilder.InsertData(
                table: "nac_attaches",
                columns: new[] { "attach_id", "name" },
                values: new object[,]
                {
                    { 5, "SOLICITUD DE CORRECCIÓN" },
                    { 1, "CERTIFICADO DE NACIDO VIVO" },
                    { 2, "CÉDULA DE CIUDADANÍA" },
                    { 3, "SENTENCIA JUDICIAL" },
                    { 4, "ESCRITURA PÚBLICA" },
                    { 6, "ACTA PARROQUIAL" }
                });

            migrationBuilder.InsertData(
                table: "places",
                columns: new[] { "place_id", "city_id", "department_id" },
                values: new object[,]
                {
                    { 1, 201, 1 },
                    { 711, 911, 19 },
                    { 712, 912, 19 },
                    { 713, 913, 19 },
                    { 714, 914, 19 },
                    { 715, 915, 19 },
                    { 716, 916, 19 },
                    { 717, 917, 19 },
                    { 718, 918, 19 },
                    { 719, 919, 19 },
                    { 720, 920, 19 },
                    { 721, 921, 19 },
                    { 722, 922, 19 },
                    { 723, 923, 19 },
                    { 724, 924, 19 },
                    { 725, 925, 19 },
                    { 726, 926, 19 },
                    { 727, 927, 20 },
                    { 728, 928, 20 },
                    { 729, 929, 20 },
                    { 730, 930, 20 },
                    { 731, 931, 20 },
                    { 732, 932, 20 },
                    { 733, 933, 20 },
                    { 734, 934, 20 },
                    { 735, 935, 20 },
                    { 736, 936, 20 },
                    { 737, 937, 20 },
                    { 738, 938, 20 },
                    { 739, 939, 20 },
                    { 710, 910, 19 },
                    { 709, 909, 19 },
                    { 708, 908, 19 },
                    { 707, 907, 19 },
                    { 677, 877, 18 },
                    { 678, 878, 18 },
                    { 679, 879, 18 },
                    { 680, 880, 18 },
                    { 681, 881, 18 },
                    { 682, 882, 18 },
                    { 683, 883, 18 },
                    { 684, 884, 18 },
                    { 685, 885, 18 },
                    { 686, 886, 18 },
                    { 687, 887, 18 },
                    { 688, 888, 18 },
                    { 689, 889, 18 },
                    { 690, 890, 18 },
                    { 740, 940, 20 },
                    { 691, 891, 18 },
                    { 693, 893, 18 },
                    { 694, 894, 18 },
                    { 695, 895, 18 },
                    { 696, 896, 18 },
                    { 697, 897, 18 },
                    { 698, 898, 19 },
                    { 699, 899, 19 },
                    { 700, 900, 19 },
                    { 701, 901, 19 },
                    { 702, 902, 19 },
                    { 703, 903, 19 },
                    { 704, 904, 19 },
                    { 705, 905, 19 },
                    { 706, 906, 19 },
                    { 692, 892, 18 },
                    { 676, 876, 18 },
                    { 741, 941, 20 },
                    { 743, 943, 20 },
                    { 778, 978, 20 },
                    { 779, 979, 20 },
                    { 780, 980, 20 },
                    { 781, 981, 20 },
                    { 782, 982, 20 },
                    { 783, 983, 20 },
                    { 784, 984, 20 },
                    { 785, 985, 20 },
                    { 786, 986, 20 },
                    { 787, 987, 20 },
                    { 788, 988, 20 },
                    { 789, 989, 21 },
                    { 790, 990, 21 },
                    { 791, 991, 21 },
                    { 792, 992, 21 },
                    { 793, 993, 21 },
                    { 794, 994, 21 },
                    { 795, 995, 21 },
                    { 796, 996, 21 },
                    { 797, 997, 21 },
                    { 798, 998, 21 },
                    { 799, 999, 21 },
                    { 800, 1000, 21 },
                    { 801, 1001, 21 },
                    { 802, 1002, 21 },
                    { 803, 1003, 21 },
                    { 804, 1004, 21 },
                    { 805, 1005, 21 },
                    { 806, 1006, 21 },
                    { 777, 977, 20 },
                    { 776, 976, 20 },
                    { 775, 975, 20 },
                    { 774, 974, 20 },
                    { 744, 944, 20 },
                    { 745, 945, 20 },
                    { 746, 946, 20 },
                    { 747, 947, 20 },
                    { 748, 948, 20 },
                    { 749, 949, 20 },
                    { 750, 950, 20 },
                    { 751, 951, 20 },
                    { 752, 952, 20 },
                    { 753, 953, 20 },
                    { 754, 954, 20 },
                    { 755, 955, 20 },
                    { 756, 956, 20 },
                    { 757, 957, 20 },
                    { 742, 942, 20 },
                    { 758, 958, 20 },
                    { 760, 960, 20 },
                    { 761, 961, 20 },
                    { 762, 962, 20 },
                    { 763, 963, 20 },
                    { 764, 964, 20 },
                    { 765, 965, 20 },
                    { 766, 966, 20 },
                    { 767, 967, 20 },
                    { 768, 968, 20 },
                    { 769, 969, 20 },
                    { 770, 970, 20 },
                    { 771, 971, 20 },
                    { 772, 972, 20 },
                    { 773, 973, 20 },
                    { 759, 959, 20 },
                    { 675, 875, 18 },
                    { 674, 874, 17 },
                    { 673, 873, 17 },
                    { 576, 776, 12 },
                    { 577, 777, 12 },
                    { 578, 778, 12 },
                    { 579, 779, 12 },
                    { 580, 780, 12 },
                    { 581, 781, 12 },
                    { 582, 782, 12 },
                    { 583, 783, 12 },
                    { 584, 784, 12 },
                    { 585, 785, 12 },
                    { 586, 786, 12 },
                    { 587, 787, 12 },
                    { 588, 788, 12 },
                    { 589, 789, 12 },
                    { 590, 790, 12 },
                    { 591, 791, 12 },
                    { 592, 792, 12 },
                    { 593, 793, 12 },
                    { 594, 794, 12 },
                    { 595, 795, 12 },
                    { 596, 796, 12 },
                    { 597, 797, 12 },
                    { 598, 798, 13 },
                    { 599, 799, 13 },
                    { 600, 800, 13 },
                    { 601, 801, 13 },
                    { 602, 802, 13 },
                    { 603, 803, 13 },
                    { 604, 804, 13 },
                    { 575, 775, 12 },
                    { 574, 774, 12 },
                    { 573, 773, 12 },
                    { 572, 772, 12 },
                    { 542, 742, 12 },
                    { 543, 743, 12 },
                    { 544, 744, 12 },
                    { 545, 745, 12 },
                    { 546, 746, 12 },
                    { 547, 747, 12 },
                    { 548, 748, 12 },
                    { 549, 749, 12 },
                    { 550, 750, 12 },
                    { 551, 751, 12 },
                    { 552, 752, 12 },
                    { 553, 753, 12 },
                    { 554, 754, 12 },
                    { 555, 755, 12 },
                    { 605, 805, 13 },
                    { 556, 756, 12 },
                    { 558, 758, 12 },
                    { 559, 759, 12 },
                    { 560, 760, 12 },
                    { 561, 761, 12 },
                    { 562, 762, 12 },
                    { 563, 763, 12 },
                    { 564, 764, 12 },
                    { 565, 765, 12 },
                    { 566, 766, 12 },
                    { 567, 767, 12 },
                    { 568, 768, 12 },
                    { 569, 769, 12 },
                    { 570, 770, 12 },
                    { 571, 771, 12 },
                    { 557, 757, 12 },
                    { 606, 806, 13 },
                    { 607, 807, 13 },
                    { 608, 808, 13 },
                    { 643, 843, 16 },
                    { 644, 844, 16 },
                    { 645, 845, 16 },
                    { 646, 846, 16 },
                    { 647, 847, 16 },
                    { 648, 848, 16 },
                    { 649, 849, 16 },
                    { 650, 850, 16 },
                    { 651, 851, 16 },
                    { 652, 852, 16 },
                    { 653, 853, 16 },
                    { 654, 854, 16 },
                    { 655, 855, 16 },
                    { 656, 856, 16 },
                    { 642, 842, 16 },
                    { 657, 857, 16 },
                    { 659, 859, 16 },
                    { 660, 860, 16 },
                    { 661, 861, 16 },
                    { 662, 862, 17 },
                    { 663, 863, 17 },
                    { 664, 864, 17 },
                    { 665, 865, 17 },
                    { 666, 866, 17 },
                    { 667, 867, 17 },
                    { 668, 868, 17 },
                    { 669, 869, 17 },
                    { 670, 870, 17 },
                    { 671, 871, 17 },
                    { 672, 872, 17 },
                    { 658, 858, 16 },
                    { 807, 1007, 21 },
                    { 641, 841, 16 },
                    { 639, 839, 16 },
                    { 609, 809, 13 },
                    { 610, 810, 13 },
                    { 611, 811, 13 },
                    { 612, 812, 13 },
                    { 613, 813, 13 },
                    { 614, 814, 13 },
                    { 615, 815, 13 },
                    { 616, 816, 13 },
                    { 617, 817, 13 },
                    { 618, 818, 13 },
                    { 619, 819, 13 },
                    { 620, 820, 14 },
                    { 621, 821, 15 },
                    { 622, 822, 15 },
                    { 640, 840, 16 },
                    { 623, 823, 15 },
                    { 625, 825, 16 },
                    { 626, 826, 16 },
                    { 627, 827, 16 },
                    { 628, 828, 16 },
                    { 629, 829, 16 },
                    { 630, 830, 16 },
                    { 631, 831, 16 },
                    { 632, 832, 16 },
                    { 633, 833, 16 },
                    { 634, 834, 16 },
                    { 635, 835, 16 },
                    { 636, 836, 16 },
                    { 637, 837, 16 },
                    { 638, 838, 16 },
                    { 624, 824, 15 },
                    { 808, 1008, 21 },
                    { 809, 1009, 21 },
                    { 810, 1010, 21 },
                    { 980, 1180, 27 },
                    { 981, 1181, 28 },
                    { 982, 1182, 28 },
                    { 983, 1183, 28 },
                    { 984, 1184, 28 },
                    { 985, 1185, 28 },
                    { 986, 1186, 28 },
                    { 987, 1187, 28 },
                    { 988, 1188, 28 },
                    { 989, 1189, 28 },
                    { 990, 1190, 28 },
                    { 991, 1191, 28 },
                    { 992, 1192, 28 },
                    { 993, 1193, 28 },
                    { 994, 1194, 28 },
                    { 995, 1195, 28 },
                    { 996, 1196, 28 },
                    { 997, 1197, 28 },
                    { 998, 1198, 28 },
                    { 999, 1199, 28 },
                    { 1000, 1200, 28 },
                    { 1001, 1201, 28 },
                    { 1002, 1202, 28 },
                    { 1003, 1203, 28 },
                    { 1004, 1204, 28 },
                    { 1005, 1205, 28 },
                    { 1006, 1206, 28 },
                    { 1007, 1207, 28 },
                    { 1008, 1208, 28 },
                    { 979, 1179, 27 },
                    { 978, 1178, 27 },
                    { 977, 1177, 27 },
                    { 976, 1176, 27 },
                    { 946, 1146, 26 },
                    { 947, 1147, 26 },
                    { 948, 1148, 26 },
                    { 949, 1149, 26 },
                    { 950, 1150, 26 },
                    { 951, 1151, 26 },
                    { 952, 1152, 26 },
                    { 953, 1153, 26 },
                    { 954, 1154, 26 },
                    { 955, 1155, 26 },
                    { 956, 1156, 26 },
                    { 957, 1157, 27 },
                    { 958, 1158, 27 },
                    { 959, 1159, 27 },
                    { 1009, 1209, 28 },
                    { 960, 1160, 27 },
                    { 962, 1162, 27 },
                    { 963, 1163, 27 },
                    { 964, 1164, 27 },
                    { 965, 1165, 27 },
                    { 966, 1166, 27 },
                    { 967, 1167, 27 },
                    { 968, 1168, 27 },
                    { 969, 1169, 27 },
                    { 970, 1170, 27 },
                    { 971, 1171, 27 },
                    { 972, 1172, 27 },
                    { 973, 1173, 27 },
                    { 974, 1174, 27 },
                    { 975, 1175, 27 },
                    { 961, 1161, 27 },
                    { 1010, 1210, 28 },
                    { 1011, 1211, 28 },
                    { 1012, 1212, 28 },
                    { 1047, 1247, 29 },
                    { 1048, 1248, 29 },
                    { 1049, 1249, 29 },
                    { 1050, 1250, 29 },
                    { 1051, 1251, 29 },
                    { 1052, 1252, 29 },
                    { 1053, 1253, 29 },
                    { 1054, 1254, 29 },
                    { 1055, 1255, 29 },
                    { 1056, 1256, 29 },
                    { 1057, 1257, 29 },
                    { 1058, 1258, 29 },
                    { 1059, 1259, 29 },
                    { 1060, 1260, 29 },
                    { 1046, 1246, 29 },
                    { 1061, 1261, 29 },
                    { 1063, 1263, 29 },
                    { 1064, 1264, 29 },
                    { 1065, 1265, 29 },
                    { 1066, 1266, 29 },
                    { 1067, 1267, 29 },
                    { 1068, 1268, 29 },
                    { 1069, 1269, 29 },
                    { 1070, 1270, 30 },
                    { 1071, 1271, 30 },
                    { 1072, 1272, 30 },
                    { 1073, 1273, 31 },
                    { 1074, 1274, 31 },
                    { 1075, 1275, 31 },
                    { 1076, 1276, 31 },
                    { 1062, 1262, 29 },
                    { 945, 1145, 26 },
                    { 1045, 1245, 29 },
                    { 1043, 1243, 29 },
                    { 1013, 1213, 28 },
                    { 1014, 1214, 28 },
                    { 1015, 1215, 28 },
                    { 1016, 1216, 28 },
                    { 1017, 1217, 28 },
                    { 1018, 1218, 28 },
                    { 1019, 1219, 28 },
                    { 1020, 1220, 28 },
                    { 1021, 1221, 28 },
                    { 1022, 1222, 28 },
                    { 1023, 1223, 28 },
                    { 1024, 1224, 28 },
                    { 1025, 1225, 28 },
                    { 1026, 1226, 28 },
                    { 1044, 1244, 29 },
                    { 1027, 1227, 28 },
                    { 1029, 1229, 29 },
                    { 1030, 1230, 29 },
                    { 1031, 1231, 29 },
                    { 1032, 1232, 29 },
                    { 1033, 1233, 29 },
                    { 1034, 1234, 29 },
                    { 1035, 1235, 29 },
                    { 1036, 1236, 29 },
                    { 1037, 1237, 29 },
                    { 1038, 1238, 29 },
                    { 1039, 1239, 29 },
                    { 1040, 1240, 29 },
                    { 1041, 1241, 29 },
                    { 1042, 1242, 29 },
                    { 1028, 1228, 29 },
                    { 540, 740, 12 },
                    { 944, 1144, 26 },
                    { 942, 1142, 26 },
                    { 845, 1045, 23 },
                    { 846, 1046, 23 },
                    { 847, 1047, 23 },
                    { 848, 1048, 23 },
                    { 849, 1049, 23 },
                    { 850, 1050, 23 },
                    { 851, 1051, 23 },
                    { 852, 1052, 23 },
                    { 853, 1053, 23 },
                    { 854, 1054, 24 },
                    { 855, 1055, 24 },
                    { 856, 1056, 24 },
                    { 857, 1057, 24 },
                    { 858, 1058, 24 },
                    { 859, 1059, 24 },
                    { 860, 1060, 24 },
                    { 861, 1061, 24 },
                    { 862, 1062, 24 },
                    { 863, 1063, 24 },
                    { 864, 1064, 24 },
                    { 865, 1065, 24 },
                    { 866, 1066, 24 },
                    { 867, 1067, 24 },
                    { 868, 1068, 25 },
                    { 869, 1069, 25 },
                    { 870, 1070, 26 },
                    { 871, 1071, 26 },
                    { 872, 1072, 26 },
                    { 873, 1073, 26 },
                    { 844, 1044, 23 },
                    { 843, 1043, 23 },
                    { 842, 1042, 23 },
                    { 841, 1041, 22 },
                    { 811, 1011, 21 },
                    { 812, 1012, 21 },
                    { 813, 1013, 21 },
                    { 814, 1014, 21 },
                    { 815, 1015, 21 },
                    { 816, 1016, 21 },
                    { 817, 1017, 21 },
                    { 818, 1018, 21 },
                    { 819, 1019, 21 },
                    { 820, 1020, 21 },
                    { 821, 1021, 21 },
                    { 822, 1022, 21 },
                    { 823, 1023, 21 },
                    { 824, 1024, 21 },
                    { 874, 1074, 26 },
                    { 825, 1025, 21 },
                    { 827, 1027, 21 },
                    { 828, 1028, 21 },
                    { 829, 1029, 22 },
                    { 830, 1030, 22 },
                    { 831, 1031, 22 },
                    { 832, 1032, 22 },
                    { 833, 1033, 22 },
                    { 834, 1034, 22 },
                    { 835, 1035, 22 },
                    { 836, 1036, 22 },
                    { 837, 1037, 22 },
                    { 838, 1038, 22 },
                    { 839, 1039, 22 },
                    { 840, 1040, 22 },
                    { 826, 1026, 21 },
                    { 875, 1075, 26 },
                    { 876, 1076, 26 },
                    { 877, 1077, 26 },
                    { 912, 1112, 26 },
                    { 913, 1113, 26 },
                    { 914, 1114, 26 },
                    { 915, 1115, 26 },
                    { 916, 1116, 26 },
                    { 917, 1117, 26 },
                    { 918, 1118, 26 },
                    { 919, 1119, 26 },
                    { 920, 1120, 26 },
                    { 921, 1121, 26 },
                    { 922, 1122, 26 },
                    { 923, 1123, 26 },
                    { 924, 1124, 26 },
                    { 925, 1125, 26 },
                    { 911, 1111, 26 },
                    { 926, 1126, 26 },
                    { 928, 1128, 26 },
                    { 929, 1129, 26 },
                    { 930, 1130, 26 },
                    { 931, 1131, 26 },
                    { 932, 1132, 26 },
                    { 933, 1133, 26 },
                    { 934, 1134, 26 },
                    { 935, 1135, 26 },
                    { 936, 1136, 26 },
                    { 937, 1137, 26 },
                    { 938, 1138, 26 },
                    { 939, 1139, 26 },
                    { 940, 1140, 26 },
                    { 941, 1141, 26 },
                    { 927, 1127, 26 },
                    { 943, 1143, 26 },
                    { 910, 1110, 26 },
                    { 908, 1108, 26 },
                    { 878, 1078, 26 },
                    { 879, 1079, 26 },
                    { 880, 1080, 26 },
                    { 881, 1081, 26 },
                    { 882, 1082, 26 },
                    { 883, 1083, 26 },
                    { 884, 1084, 26 },
                    { 885, 1085, 26 },
                    { 886, 1086, 26 },
                    { 887, 1087, 26 },
                    { 888, 1088, 26 },
                    { 889, 1089, 26 },
                    { 890, 1090, 26 },
                    { 891, 1091, 26 },
                    { 909, 1109, 26 },
                    { 892, 1092, 26 },
                    { 894, 1094, 26 },
                    { 895, 1095, 26 },
                    { 896, 1096, 26 },
                    { 897, 1097, 26 },
                    { 898, 1098, 26 },
                    { 899, 1099, 26 },
                    { 900, 1100, 26 },
                    { 901, 1101, 26 },
                    { 902, 1102, 26 },
                    { 903, 1103, 26 },
                    { 904, 1104, 26 },
                    { 905, 1105, 26 },
                    { 906, 1106, 26 },
                    { 907, 1107, 26 },
                    { 893, 1093, 26 },
                    { 539, 739, 12 },
                    { 541, 741, 12 },
                    { 537, 737, 12 },
                    { 171, 371, 4 },
                    { 172, 372, 4 },
                    { 173, 373, 4 },
                    { 174, 374, 4 },
                    { 175, 375, 4 },
                    { 176, 376, 4 },
                    { 177, 377, 4 },
                    { 178, 378, 4 },
                    { 179, 379, 4 },
                    { 180, 380, 4 },
                    { 181, 381, 4 },
                    { 182, 382, 4 },
                    { 183, 383, 4 },
                    { 184, 384, 4 },
                    { 185, 385, 4 },
                    { 186, 386, 4 },
                    { 187, 387, 4 },
                    { 188, 388, 4 },
                    { 189, 389, 4 },
                    { 190, 390, 4 },
                    { 191, 391, 4 },
                    { 192, 392, 4 },
                    { 193, 393, 4 },
                    { 194, 394, 4 },
                    { 195, 395, 4 },
                    { 196, 396, 4 },
                    { 197, 397, 4 },
                    { 198, 398, 4 },
                    { 199, 399, 4 },
                    { 170, 370, 4 },
                    { 169, 369, 4 },
                    { 168, 368, 4 },
                    { 167, 367, 4 },
                    { 137, 337, 4 },
                    { 138, 338, 4 },
                    { 139, 339, 4 },
                    { 140, 340, 4 },
                    { 141, 341, 4 },
                    { 142, 342, 4 },
                    { 143, 343, 4 },
                    { 144, 344, 4 },
                    { 145, 345, 4 },
                    { 146, 346, 4 },
                    { 147, 347, 4 },
                    { 148, 348, 4 },
                    { 149, 349, 4 },
                    { 150, 350, 4 },
                    { 200, 400, 4 },
                    { 151, 351, 4 },
                    { 153, 353, 4 },
                    { 154, 354, 4 },
                    { 155, 355, 4 },
                    { 156, 356, 4 },
                    { 157, 357, 4 },
                    { 158, 358, 4 },
                    { 159, 359, 4 },
                    { 160, 360, 4 },
                    { 161, 361, 4 },
                    { 162, 362, 4 },
                    { 163, 363, 4 },
                    { 164, 364, 4 },
                    { 165, 365, 4 },
                    { 166, 366, 4 },
                    { 152, 352, 4 },
                    { 201, 401, 4 },
                    { 202, 402, 4 },
                    { 203, 403, 4 },
                    { 238, 438, 5 },
                    { 239, 439, 5 },
                    { 240, 440, 5 },
                    { 241, 441, 5 },
                    { 242, 442, 5 },
                    { 243, 443, 5 },
                    { 244, 444, 5 },
                    { 245, 445, 5 },
                    { 246, 446, 5 },
                    { 247, 447, 5 },
                    { 248, 448, 5 },
                    { 249, 449, 5 },
                    { 250, 450, 5 },
                    { 251, 451, 5 },
                    { 237, 437, 5 },
                    { 252, 452, 5 },
                    { 254, 454, 5 },
                    { 255, 455, 5 },
                    { 256, 456, 5 },
                    { 257, 457, 5 },
                    { 258, 458, 5 },
                    { 259, 459, 5 },
                    { 260, 460, 5 },
                    { 261, 461, 5 },
                    { 262, 462, 5 },
                    { 263, 463, 5 },
                    { 264, 464, 5 },
                    { 265, 465, 5 },
                    { 266, 466, 5 },
                    { 267, 467, 5 },
                    { 253, 453, 5 },
                    { 136, 336, 3 },
                    { 236, 436, 5 },
                    { 234, 434, 5 },
                    { 204, 404, 4 },
                    { 205, 405, 5 },
                    { 206, 406, 5 },
                    { 207, 407, 5 },
                    { 208, 408, 5 },
                    { 209, 409, 5 },
                    { 210, 410, 5 },
                    { 211, 411, 5 },
                    { 212, 412, 5 },
                    { 213, 413, 5 },
                    { 214, 414, 5 },
                    { 215, 415, 5 },
                    { 216, 416, 5 },
                    { 217, 417, 5 },
                    { 235, 435, 5 },
                    { 218, 418, 5 },
                    { 220, 420, 5 },
                    { 221, 421, 5 },
                    { 222, 422, 5 },
                    { 223, 423, 5 },
                    { 224, 424, 5 },
                    { 225, 425, 5 },
                    { 226, 426, 5 },
                    { 227, 427, 5 },
                    { 228, 428, 5 },
                    { 229, 429, 5 },
                    { 230, 430, 5 },
                    { 231, 431, 5 },
                    { 232, 432, 5 },
                    { 233, 433, 5 },
                    { 219, 419, 5 },
                    { 538, 738, 12 },
                    { 135, 335, 3 },
                    { 133, 333, 3 },
                    { 36, 236, 2 },
                    { 37, 237, 2 },
                    { 38, 238, 2 },
                    { 39, 239, 2 },
                    { 40, 240, 2 },
                    { 41, 241, 2 },
                    { 42, 242, 2 },
                    { 43, 243, 2 },
                    { 44, 244, 2 },
                    { 45, 245, 2 },
                    { 46, 246, 2 },
                    { 47, 247, 2 },
                    { 48, 248, 2 },
                    { 49, 249, 2 },
                    { 50, 250, 2 },
                    { 51, 251, 2 },
                    { 52, 252, 2 },
                    { 53, 253, 2 },
                    { 54, 254, 2 },
                    { 55, 255, 2 },
                    { 56, 256, 2 },
                    { 57, 257, 2 },
                    { 58, 258, 2 },
                    { 59, 259, 2 }
                });

            migrationBuilder.InsertData(
                table: "places",
                columns: new[] { "place_id", "city_id", "department_id" },
                values: new object[,]
                {
                    { 60, 260, 2 },
                    { 61, 261, 2 },
                    { 62, 262, 2 },
                    { 63, 263, 2 },
                    { 64, 264, 2 },
                    { 35, 235, 2 },
                    { 34, 234, 2 },
                    { 33, 233, 2 },
                    { 32, 232, 2 },
                    { 2, 202, 1 },
                    { 3, 203, 2 },
                    { 4, 204, 2 },
                    { 5, 205, 2 },
                    { 6, 206, 2 },
                    { 7, 207, 2 },
                    { 8, 208, 2 },
                    { 9, 209, 2 },
                    { 10, 210, 2 },
                    { 11, 211, 2 },
                    { 12, 212, 2 },
                    { 13, 213, 2 },
                    { 14, 214, 2 },
                    { 15, 215, 2 },
                    { 65, 265, 2 },
                    { 16, 216, 2 },
                    { 18, 218, 2 },
                    { 19, 219, 2 },
                    { 20, 220, 2 },
                    { 21, 221, 2 },
                    { 22, 222, 2 },
                    { 23, 223, 2 },
                    { 24, 224, 2 },
                    { 25, 225, 2 },
                    { 26, 226, 2 },
                    { 27, 227, 2 },
                    { 28, 228, 2 },
                    { 29, 229, 2 },
                    { 30, 230, 2 },
                    { 31, 231, 2 },
                    { 17, 217, 2 },
                    { 66, 266, 2 },
                    { 67, 267, 2 },
                    { 68, 268, 2 },
                    { 103, 303, 2 },
                    { 104, 304, 2 },
                    { 105, 305, 2 },
                    { 106, 306, 2 },
                    { 107, 307, 2 },
                    { 108, 308, 2 },
                    { 109, 309, 2 },
                    { 110, 310, 2 },
                    { 111, 311, 2 },
                    { 112, 312, 2 },
                    { 113, 313, 2 },
                    { 114, 314, 2 },
                    { 115, 315, 2 },
                    { 116, 316, 2 },
                    { 102, 302, 2 },
                    { 117, 317, 2 },
                    { 119, 319, 2 },
                    { 120, 320, 2 },
                    { 121, 321, 2 },
                    { 122, 322, 2 },
                    { 123, 323, 2 },
                    { 124, 324, 2 },
                    { 125, 325, 2 },
                    { 126, 326, 2 },
                    { 127, 327, 2 },
                    { 128, 328, 3 },
                    { 129, 329, 3 },
                    { 130, 330, 3 },
                    { 131, 331, 3 },
                    { 132, 332, 3 },
                    { 118, 318, 2 },
                    { 134, 334, 3 },
                    { 101, 301, 2 },
                    { 99, 299, 2 },
                    { 69, 269, 2 },
                    { 70, 270, 2 },
                    { 71, 271, 2 },
                    { 72, 272, 2 },
                    { 73, 273, 2 },
                    { 74, 274, 2 },
                    { 75, 275, 2 },
                    { 76, 276, 2 },
                    { 77, 277, 2 },
                    { 78, 278, 2 },
                    { 79, 279, 2 },
                    { 80, 280, 2 },
                    { 81, 281, 2 },
                    { 82, 282, 2 },
                    { 100, 300, 2 },
                    { 83, 283, 2 },
                    { 85, 285, 2 },
                    { 86, 286, 2 },
                    { 87, 287, 2 },
                    { 88, 288, 2 },
                    { 89, 289, 2 },
                    { 90, 290, 2 },
                    { 91, 291, 2 },
                    { 92, 292, 2 },
                    { 93, 293, 2 },
                    { 94, 294, 2 },
                    { 95, 295, 2 },
                    { 96, 296, 2 },
                    { 97, 297, 2 },
                    { 98, 298, 2 },
                    { 84, 284, 2 },
                    { 269, 469, 5 },
                    { 268, 468, 5 },
                    { 271, 471, 5 },
                    { 441, 641, 10 },
                    { 442, 642, 10 },
                    { 443, 643, 10 },
                    { 444, 644, 10 },
                    { 445, 645, 10 },
                    { 446, 646, 10 },
                    { 447, 647, 10 },
                    { 448, 648, 10 },
                    { 449, 649, 10 },
                    { 450, 650, 10 },
                    { 451, 651, 10 },
                    { 452, 652, 10 },
                    { 453, 653, 11 },
                    { 454, 654, 11 },
                    { 455, 655, 11 },
                    { 456, 656, 11 },
                    { 457, 657, 11 },
                    { 458, 658, 11 },
                    { 459, 659, 11 },
                    { 460, 660, 11 },
                    { 461, 661, 11 },
                    { 462, 662, 11 },
                    { 463, 663, 11 },
                    { 464, 664, 11 },
                    { 465, 665, 11 },
                    { 466, 666, 11 },
                    { 467, 667, 11 },
                    { 468, 668, 11 },
                    { 469, 669, 11 },
                    { 440, 640, 10 },
                    { 439, 639, 10 },
                    { 438, 638, 10 },
                    { 437, 637, 10 },
                    { 407, 607, 9 },
                    { 408, 608, 9 },
                    { 409, 609, 9 },
                    { 410, 610, 9 },
                    { 411, 611, 9 },
                    { 412, 612, 9 },
                    { 413, 613, 9 },
                    { 414, 614, 9 },
                    { 415, 615, 9 },
                    { 416, 616, 9 },
                    { 417, 617, 9 },
                    { 418, 618, 9 },
                    { 419, 619, 9 },
                    { 420, 620, 9 },
                    { 470, 670, 11 },
                    { 421, 621, 9 },
                    { 423, 623, 9 },
                    { 424, 624, 9 },
                    { 425, 625, 9 },
                    { 426, 626, 9 },
                    { 427, 627, 9 },
                    { 428, 628, 10 },
                    { 429, 629, 10 },
                    { 430, 630, 10 },
                    { 431, 631, 10 },
                    { 432, 632, 10 },
                    { 433, 633, 10 },
                    { 434, 634, 10 },
                    { 435, 635, 10 },
                    { 436, 636, 10 },
                    { 422, 622, 9 },
                    { 270, 470, 5 },
                    { 471, 671, 11 },
                    { 473, 673, 11 },
                    { 508, 708, 12 },
                    { 509, 709, 12 },
                    { 510, 710, 12 },
                    { 511, 711, 12 },
                    { 512, 712, 12 },
                    { 513, 713, 12 },
                    { 514, 714, 12 },
                    { 515, 715, 12 },
                    { 516, 716, 12 },
                    { 517, 717, 12 },
                    { 518, 718, 12 },
                    { 519, 719, 12 },
                    { 520, 720, 12 },
                    { 521, 721, 12 },
                    { 522, 722, 12 },
                    { 523, 723, 12 },
                    { 524, 724, 12 },
                    { 525, 725, 12 },
                    { 526, 726, 12 },
                    { 527, 727, 12 },
                    { 528, 728, 12 },
                    { 529, 729, 12 },
                    { 530, 730, 12 },
                    { 531, 731, 12 },
                    { 532, 732, 12 },
                    { 533, 733, 12 },
                    { 534, 734, 12 },
                    { 535, 735, 12 },
                    { 536, 736, 12 },
                    { 507, 707, 12 },
                    { 506, 706, 12 },
                    { 505, 705, 12 },
                    { 504, 704, 12 },
                    { 474, 674, 11 },
                    { 475, 675, 11 },
                    { 476, 676, 11 },
                    { 477, 677, 11 },
                    { 478, 678, 11 },
                    { 479, 679, 11 },
                    { 480, 680, 11 },
                    { 481, 681, 12 },
                    { 482, 682, 12 },
                    { 483, 683, 12 },
                    { 484, 684, 12 },
                    { 485, 685, 12 },
                    { 486, 686, 12 },
                    { 487, 687, 12 },
                    { 472, 672, 11 },
                    { 488, 688, 12 },
                    { 490, 690, 12 },
                    { 491, 691, 12 },
                    { 492, 692, 12 },
                    { 493, 693, 12 },
                    { 494, 694, 12 },
                    { 495, 695, 12 },
                    { 496, 696, 12 },
                    { 497, 697, 12 },
                    { 498, 698, 12 },
                    { 499, 699, 12 },
                    { 500, 700, 12 },
                    { 501, 701, 12 },
                    { 502, 702, 12 },
                    { 503, 703, 12 },
                    { 489, 689, 12 },
                    { 405, 605, 9 },
                    { 406, 606, 9 },
                    { 403, 603, 9 },
                    { 306, 506, 5 },
                    { 307, 507, 5 },
                    { 308, 508, 5 },
                    { 309, 509, 5 },
                    { 310, 510, 5 },
                    { 311, 511, 5 },
                    { 312, 512, 5 },
                    { 313, 513, 5 },
                    { 314, 514, 5 },
                    { 315, 515, 5 },
                    { 316, 516, 5 },
                    { 317, 517, 5 },
                    { 318, 518, 5 },
                    { 319, 519, 5 },
                    { 320, 520, 5 },
                    { 321, 521, 5 },
                    { 322, 522, 5 },
                    { 323, 523, 5 },
                    { 324, 524, 5 },
                    { 325, 525, 5 },
                    { 326, 526, 5 },
                    { 327, 527, 5 },
                    { 328, 528, 6 },
                    { 329, 529, 6 },
                    { 330, 530, 6 },
                    { 331, 531, 6 },
                    { 332, 532, 6 },
                    { 333, 533, 6 },
                    { 334, 534, 6 },
                    { 305, 505, 5 },
                    { 304, 504, 5 },
                    { 303, 503, 5 },
                    { 302, 502, 5 },
                    { 272, 472, 5 },
                    { 273, 473, 5 },
                    { 274, 474, 5 },
                    { 275, 475, 5 },
                    { 276, 476, 5 },
                    { 277, 477, 5 },
                    { 278, 478, 5 },
                    { 279, 479, 5 },
                    { 280, 480, 5 },
                    { 281, 481, 5 },
                    { 282, 482, 5 },
                    { 283, 483, 5 },
                    { 284, 484, 5 },
                    { 285, 485, 5 },
                    { 404, 604, 9 },
                    { 286, 486, 5 },
                    { 288, 488, 5 },
                    { 289, 489, 5 },
                    { 290, 490, 5 },
                    { 291, 491, 5 },
                    { 292, 492, 5 },
                    { 293, 493, 5 },
                    { 294, 494, 5 },
                    { 295, 495, 5 },
                    { 296, 496, 5 },
                    { 297, 497, 5 },
                    { 298, 498, 5 },
                    { 299, 499, 5 },
                    { 300, 500, 5 },
                    { 301, 501, 5 },
                    { 287, 487, 5 },
                    { 336, 536, 6 },
                    { 335, 535, 6 },
                    { 338, 538, 6 },
                    { 337, 537, 6 },
                    { 374, 574, 8 },
                    { 375, 575, 8 },
                    { 376, 576, 8 },
                    { 377, 577, 8 },
                    { 378, 578, 8 },
                    { 379, 579, 8 },
                    { 380, 580, 8 },
                    { 381, 581, 8 },
                    { 382, 582, 8 },
                    { 383, 583, 8 },
                    { 384, 584, 8 },
                    { 385, 585, 8 },
                    { 386, 586, 8 },
                    { 372, 572, 8 },
                    { 387, 587, 8 },
                    { 389, 589, 9 },
                    { 390, 590, 9 },
                    { 391, 591, 9 },
                    { 392, 592, 9 },
                    { 393, 593, 9 },
                    { 394, 594, 9 },
                    { 395, 595, 9 },
                    { 396, 596, 9 },
                    { 397, 597, 9 },
                    { 398, 598, 9 },
                    { 399, 599, 9 },
                    { 400, 600, 9 },
                    { 401, 601, 9 },
                    { 402, 602, 9 },
                    { 388, 588, 8 },
                    { 371, 571, 8 },
                    { 373, 573, 8 },
                    { 369, 569, 7 },
                    { 339, 539, 6 },
                    { 340, 540, 6 },
                    { 341, 541, 6 },
                    { 342, 542, 6 },
                    { 343, 543, 6 },
                    { 344, 544, 6 },
                    { 345, 545, 6 },
                    { 346, 546, 6 },
                    { 347, 547, 6 },
                    { 348, 548, 6 },
                    { 349, 549, 6 },
                    { 350, 550, 6 },
                    { 370, 570, 8 },
                    { 352, 552, 6 },
                    { 353, 553, 6 },
                    { 351, 551, 6 },
                    { 355, 555, 7 },
                    { 368, 568, 7 },
                    { 367, 567, 7 },
                    { 366, 566, 7 },
                    { 365, 565, 7 },
                    { 354, 554, 7 },
                    { 363, 563, 7 },
                    { 364, 564, 7 },
                    { 361, 561, 7 },
                    { 360, 560, 7 },
                    { 359, 559, 7 },
                    { 358, 558, 7 },
                    { 357, 557, 7 },
                    { 356, 556, 7 },
                    { 362, 562, 7 }
                });

            migrationBuilder.InsertData(
                table: "usuarios",
                columns: new[] { "id", "birth_date", "doctype_id", "expedition_date", "expedition_place", "name", "surname" },
                values: new object[,]
                {
                    { "719912", new DateTime(1942, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SALGAR", "VILEY DE JESÚS", "DÍAZ GARCÍA" },
                    { "1001268575", new DateTime(2001, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2019, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "SALGAR", "JUAN SEBASTIÁN", "DÍAZ OSORIO" },
                    { "1039760194", new DateTime(1992, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SALGAR", "ANA CRISTINA", "DÍAZ OSORIO" },
                    { "21979476", new DateTime(1970, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SALGAR", "RUTH NELLY", "OSORIO GARCÍA" },
                    { "98509595", new DateTime(1970, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SALGAR", "JAVIER ALONSO", "DÍAZ GALLEGO" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "bloodtypes",
                keyColumn: "bloodtype_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "bloodtypes",
                keyColumn: "bloodtype_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "bloodtypes",
                keyColumn: "bloodtype_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "bloodtypes",
                keyColumn: "bloodtype_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "bloodtypes",
                keyColumn: "bloodtype_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "bloodtypes",
                keyColumn: "bloodtype_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "bloodtypes",
                keyColumn: "bloodtype_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "bloodtypes",
                keyColumn: "bloodtype_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "doctypes",
                keyColumn: "doctype_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "doctypes",
                keyColumn: "doctype_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "mat_attaches",
                keyColumn: "attach_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "mat_attaches",
                keyColumn: "attach_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "nac_attaches",
                keyColumn: "attach_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "nac_attaches",
                keyColumn: "attach_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "nac_attaches",
                keyColumn: "attach_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "nac_attaches",
                keyColumn: "attach_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "nac_attaches",
                keyColumn: "attach_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "nac_attaches",
                keyColumn: "attach_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "places",
                keyColumn: "place_id",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "usuarios",
                keyColumn: "id",
                keyValue: "1001268575");

            migrationBuilder.DeleteData(
                table: "usuarios",
                keyColumn: "id",
                keyValue: "1039760194");

            migrationBuilder.DeleteData(
                table: "usuarios",
                keyColumn: "id",
                keyValue: "21979476");

            migrationBuilder.DeleteData(
                table: "usuarios",
                keyColumn: "id",
                keyValue: "719912");

            migrationBuilder.DeleteData(
                table: "usuarios",
                keyColumn: "id",
                keyValue: "98509595");

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "id",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "doctypes",
                keyColumn: "doctype_id",
                keyValue: 1);
        }
    }
}

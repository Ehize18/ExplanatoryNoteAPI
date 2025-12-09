--
-- PostgreSQL database dump
--

-- Dumped from database version 17.6 (Debian 17.6-1.pgdg13+1)
-- Dumped by pg_dump version 17.1

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Data for Name: SysUser; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: AdditionalData; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: RegionsRF; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."RegionsRF" VALUES ('6bdba408-d6fd-49e2-9b59-d7a25feada74', 'Республика Карелия', '10');
INSERT INTO public."RegionsRF" VALUES ('8fee6df5-b869-4cba-ab58-f5d860a7f318', 'Карачаево-Черкесская Республика', '09');
INSERT INTO public."RegionsRF" VALUES ('cc3cd19b-1128-43a4-8517-47f73f91ae40', 'Республика Калмыкия', '08');
INSERT INTO public."RegionsRF" VALUES ('56873a65-4f9b-44a6-818c-ffa1c30434ef', 'Кабардино-Балкарская Республика', '07');
INSERT INTO public."RegionsRF" VALUES ('1c080dfa-2500-460c-a4ce-f3895ad3e42f', 'Республика Ингушетия', '06');
INSERT INTO public."RegionsRF" VALUES ('13a52b86-51ca-4fe4-b3c0-6c43fd60e4e0', 'Республика Дагестан', '05');
INSERT INTO public."RegionsRF" VALUES ('b91761aa-8af2-4692-bb88-ac5e5afbe68e', 'Республика Алтай', '04');
INSERT INTO public."RegionsRF" VALUES ('a40af951-419d-4cbe-a7c7-fe650d338051', 'Республика Бурятия', '03');
INSERT INTO public."RegionsRF" VALUES ('bb3bc9de-17f3-4b44-8870-35b854c618c8', 'Республика Башкортостан', '02');
INSERT INTO public."RegionsRF" VALUES ('f96bd2be-209e-447b-a14b-9447dadda760', 'Республика Адыгея (Адыгея)', '01');
INSERT INTO public."RegionsRF" VALUES ('d6a9f7f8-e184-4ebd-8cc4-f16c353fd037', 'Объект расположен за пределами территории Российской Федерации, во внутренних морских водах, территориальном море и прилежащей зоне Российской Федерации, в исключительной экономической зоне Российской Федерации, в границах российской части (российском секторе) дна Каспийского моря и континентального шельфа Российской Федерации', '00');
INSERT INTO public."RegionsRF" VALUES ('187864e2-778c-4f1a-b252-56e30330160f', 'Чеченская Республика', '20');
INSERT INTO public."RegionsRF" VALUES ('b4ba6a1b-c512-44bb-a486-9047b0b583f5', 'Республика Хакасия', '19');
INSERT INTO public."RegionsRF" VALUES ('8dfe023c-54ad-46e9-a8cf-aaa41c73767b', 'Удмуртская Республика', '18');
INSERT INTO public."RegionsRF" VALUES ('63690fe3-655e-4efa-98fb-2605f79de62a', 'Республика Тыва', '17');
INSERT INTO public."RegionsRF" VALUES ('38924660-8239-4d30-a040-741ff5bfc5a6', 'Республика Татарстан (Татарстан)', '16');
INSERT INTO public."RegionsRF" VALUES ('bc468276-2831-44a5-8546-0eb1c787ae4b', 'Республика Северная Осетия - Алания', '15');
INSERT INTO public."RegionsRF" VALUES ('42d842ce-b02b-4295-a908-8b958505262d', 'Республика Саха (Якутия)', '14');
INSERT INTO public."RegionsRF" VALUES ('c52128dc-edc8-4e9f-bb9d-77492c29c1ef', 'Республика Мордовия', '13');
INSERT INTO public."RegionsRF" VALUES ('c997198d-890c-4737-a3d8-7037231a024b', 'Республика Марий Эл', '12');
INSERT INTO public."RegionsRF" VALUES ('0cd5d082-2285-40bf-8e67-56af552c5837', 'Республика Коми', '11');
INSERT INTO public."RegionsRF" VALUES ('0d855e5c-3f9c-4192-bf77-0ca025d8ba10', 'Астраханская область', '30');
INSERT INTO public."RegionsRF" VALUES ('852b2301-9125-41c4-9c11-5425bb11b3be', 'Архангельская область', '29');
INSERT INTO public."RegionsRF" VALUES ('d6a651b6-b01b-4bbb-ae7b-d37b00780d0e', 'Амурская область', '28');
INSERT INTO public."RegionsRF" VALUES ('f37ddade-a5d3-4d3e-a347-0983ce6a49b7', 'Хабаровский край', '27');
INSERT INTO public."RegionsRF" VALUES ('2aed2690-a4f4-4423-af69-8abbcd470625', 'Ставропольский край', '26');
INSERT INTO public."RegionsRF" VALUES ('ec0ea4c9-baef-4301-ad08-2db3e9584576', 'Приморский край', '25');
INSERT INTO public."RegionsRF" VALUES ('bbe4591f-bc26-47b3-94b6-1c2b24a705c3', 'Красноярский край', '24');
INSERT INTO public."RegionsRF" VALUES ('911ac760-ab97-4fd5-89c1-91ddb6ff78b0', 'Краснодарский край', '23');
INSERT INTO public."RegionsRF" VALUES ('253a14a0-60a3-42e5-a424-91dfde3e1455', 'Алтайский край', '22');
INSERT INTO public."RegionsRF" VALUES ('109abb3e-0112-4cdb-b3cf-0f22318f4e58', 'Чувашская Республика - Чувашия', '21');
INSERT INTO public."RegionsRF" VALUES ('39fdd734-a450-44a1-b30d-0dd51e60b3dc', 'Калужская область', '40');
INSERT INTO public."RegionsRF" VALUES ('3cfd3abb-abb1-40a0-8bef-3e1fae44ce4d', 'Калининградская область', '39');
INSERT INTO public."RegionsRF" VALUES ('171643da-7a08-4e9b-9a71-d7c0629c0c73', 'Иркутская область', '38');
INSERT INTO public."RegionsRF" VALUES ('67e6496b-f423-4c63-867f-747a7ec549a5', 'Ивановская область', '37');
INSERT INTO public."RegionsRF" VALUES ('f00a79d9-87a3-4504-991a-427a2bdd99d4', 'Воронежская область', '36');
INSERT INTO public."RegionsRF" VALUES ('7004e6a3-04fb-484d-9724-27f7fd5fbb7d', 'Вологодская область', '35');
INSERT INTO public."RegionsRF" VALUES ('1218c4a7-df9b-4523-8101-e2f5e1b922ac', 'Волгоградская область', '34');
INSERT INTO public."RegionsRF" VALUES ('f5a56f86-1511-4560-afcf-858e66f1c5ab', 'Владимирская область', '33');
INSERT INTO public."RegionsRF" VALUES ('dae6198c-5bea-4c29-82aa-d39be8b3c23a', 'Брянская область', '32');
INSERT INTO public."RegionsRF" VALUES ('67f99e77-eabf-4553-9341-daf43e7fc40f', 'Белгородская область', '31');
INSERT INTO public."RegionsRF" VALUES ('5b499c44-126b-4730-9967-b16a1923936f', 'Московская область', '50');
INSERT INTO public."RegionsRF" VALUES ('91a18df0-ed02-495b-ae72-22d0de2ac96d', 'Магаданская область', '49');
INSERT INTO public."RegionsRF" VALUES ('3e786c8c-2d7d-4c9b-a70d-373faf719627', 'Липецкая область', '48');
INSERT INTO public."RegionsRF" VALUES ('53a0152b-028c-4b6c-b67c-16dba7fb2b12', 'Ленинградская область', '47');
INSERT INTO public."RegionsRF" VALUES ('ae68b2ce-930d-4793-a27e-342a3d50413c', 'Курская область', '46');
INSERT INTO public."RegionsRF" VALUES ('b4a73b6d-2869-481f-b6c1-2cfe87ddce0b', 'Курганская область', '45');
INSERT INTO public."RegionsRF" VALUES ('d35d4ac5-7c01-4aa4-8c92-cc31b3ef0494', 'Костромская область', '44');
INSERT INTO public."RegionsRF" VALUES ('271b1986-2672-4632-b661-9511beac0be6', 'Кировская область', '43');
INSERT INTO public."RegionsRF" VALUES ('b384d42d-b2d9-464c-9cac-df618d25b181', 'Кемеровская область - Кузбасс', '42');
INSERT INTO public."RegionsRF" VALUES ('62a9518b-1c38-4796-af4f-26a3037a1750', 'Камчатский край', '41');
INSERT INTO public."RegionsRF" VALUES ('1d424fed-0ae5-4184-a9e8-49265c19aad3', 'Псковская область', '60');
INSERT INTO public."RegionsRF" VALUES ('3825cbf9-8120-4ed6-aa0a-1a4e105a4726', 'Пермский край', '59');
INSERT INTO public."RegionsRF" VALUES ('ce61ce6e-e787-4b8e-b0c7-74ea7151ee7f', 'Пензенская область', '58');
INSERT INTO public."RegionsRF" VALUES ('745635e0-77f6-4f4b-8699-c41d1f6e65e1', 'Орловская область', '57');
INSERT INTO public."RegionsRF" VALUES ('6005c2b0-dd81-4931-b0ad-7b1ca7292f24', 'Оренбургская область', '56');
INSERT INTO public."RegionsRF" VALUES ('5a2890ad-6cbd-4fe2-ade6-c639f322de4a', 'Омская область', '55');
INSERT INTO public."RegionsRF" VALUES ('a9c6d4ea-7d50-4c5b-840c-b7e83109987b', 'Новосибирская область', '54');
INSERT INTO public."RegionsRF" VALUES ('8f7e4a57-39be-45e7-bf1f-0ef3738a0f0d', 'Новгородская область', '53');
INSERT INTO public."RegionsRF" VALUES ('b428bf52-5518-4683-9223-9ef4415ec794', 'Нижегородская область', '52');
INSERT INTO public."RegionsRF" VALUES ('59db0eaa-4f99-4dc9-833e-d327ef1fcbd4', 'Мурманская область', '51');
INSERT INTO public."RegionsRF" VALUES ('3a427822-ee0e-4753-9503-5de02351f564', 'Томская область', '70');
INSERT INTO public."RegionsRF" VALUES ('3d04545b-b8e9-4c5b-86c4-a857a1e224ae', 'Тверская область', '69');
INSERT INTO public."RegionsRF" VALUES ('9df2bfdf-ab71-4958-bffd-db0a3ece8a9c', 'Тамбовская область', '68');
INSERT INTO public."RegionsRF" VALUES ('ddf3dfb2-6576-4b44-a75d-1eb82ed83640', 'Смоленская область', '67');
INSERT INTO public."RegionsRF" VALUES ('043a40f6-a4b8-41b7-a108-27920877e320', 'Свердловская область', '66');
INSERT INTO public."RegionsRF" VALUES ('390ab80a-9fdc-46a0-9ac1-c7d08a653fba', 'Сахалинская область', '65');
INSERT INTO public."RegionsRF" VALUES ('3cefe84c-926f-463f-ac08-7da68a0871f7', 'Саратовская область', '64');
INSERT INTO public."RegionsRF" VALUES ('6e8a8935-cacb-4290-9db6-90af4c7f150e', 'Самарская область', '63');
INSERT INTO public."RegionsRF" VALUES ('4781a872-e88d-4d6e-ac52-cee67ff6a0ee', 'Рязанская область', '62');
INSERT INTO public."RegionsRF" VALUES ('6c320514-488a-4651-837f-80d5053b1443', 'Ростовская область', '61');
INSERT INTO public."RegionsRF" VALUES ('43854bb9-aa69-485c-87ce-c39543eee05b', 'Донецкая Народная Республика', '80');
INSERT INTO public."RegionsRF" VALUES ('862dc132-53e3-48ae-b0e0-246d5ac92ec6', 'Еврейская автономная область', '79');
INSERT INTO public."RegionsRF" VALUES ('7aee4c87-6b16-449c-bd8f-c8f885d9d298', 'Санкт-Петербург', '78');
INSERT INTO public."RegionsRF" VALUES ('766d73dc-50b0-4c45-aee9-f84fec906607', 'Москва', '77');
INSERT INTO public."RegionsRF" VALUES ('c09f02f3-4d51-49ea-9b0e-9065857191b9', 'Ярославская область', '76');
INSERT INTO public."RegionsRF" VALUES ('2b8120ff-032b-401d-bb1f-5bcc6b15faac', 'Забайкальский край', '75');
INSERT INTO public."RegionsRF" VALUES ('b01a7593-f05e-4fa0-bedf-04b9e03dfaa5', 'Челябинская область', '74');
INSERT INTO public."RegionsRF" VALUES ('70cec69f-1a88-4d49-aa1e-1402b8262d45', 'Ульяновская область', '73');
INSERT INTO public."RegionsRF" VALUES ('66d9848e-ac7a-4991-b866-dfa524d8cf2b', 'Тюменская область', '72');
INSERT INTO public."RegionsRF" VALUES ('331737b1-b519-49dd-8728-174c467c7d92', 'Тульская область', '71');
INSERT INTO public."RegionsRF" VALUES ('ff5a0ba9-ea70-43e9-8b94-18ae74ae6394', 'Севастополь', '92');
INSERT INTO public."RegionsRF" VALUES ('f93e6023-3fc9-4d29-81d2-a29678c5688d', 'Республика Крым', '91');
INSERT INTO public."RegionsRF" VALUES ('d1617cc3-1a3e-4621-962a-65ab38dbfea4', 'Ямало-Ненецкий автономный округ', '89');
INSERT INTO public."RegionsRF" VALUES ('9e488186-d0eb-46e7-91b0-6c3a76b0ce5c', 'Чукотский автономный округ', '87');
INSERT INTO public."RegionsRF" VALUES ('88523467-96a1-4b71-ad10-144a8f34d62c', 'Ханты-Мансийский автономный округ - Югра', '86');
INSERT INTO public."RegionsRF" VALUES ('82306acf-fcc7-464a-91ef-b07ce76bd80c', 'Запорожская область', '85');
INSERT INTO public."RegionsRF" VALUES ('6c5c928f-9c55-4d77-b190-f45b6a60c729', 'Херсонская область', '84');
INSERT INTO public."RegionsRF" VALUES ('81ccfa4b-1fb8-41db-9ae5-08f8f4a075eb', 'Ненецкий автономный округ', '83');
INSERT INTO public."RegionsRF" VALUES ('cc92af1c-7cf6-4586-bf92-5b161c01af89', 'Луганская Народная Республика', '81');


--
-- Data for Name: Address; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: DocumentType; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."DocumentType" VALUES ('04505575-9b2c-48d1-9cae-498c8a8450f5', 'Заявление о проведении экспертизы', '01.01');
INSERT INTO public."DocumentType" VALUES ('45c2d103-13a0-4638-b0b7-0b24abb2f5d7', 'Договор о проведении экспертизы', '01.02');
INSERT INTO public."DocumentType" VALUES ('ea5ef304-3b43-4c7f-ab3b-00b0c6af340f', 'Документ, подтверждающий полномочия заявителя действовать от имени застройщика, технического заказчика, лица, обеспечившего выполнение инженерных изысканий и (или) подготовку проектной документации в случаях, предусмотренных частями 1.1 и 1.2 статьи 48 Градостроительного кодекса Российской Федерации', '01.03');
INSERT INTO public."DocumentType" VALUES ('c4824500-26d8-40bf-8b1c-95d92709154d', 'Иные документы', '01.99');
INSERT INTO public."DocumentType" VALUES ('b79e461a-c5d0-4dc9-af4c-1fff82b9461e', 'Иные заключения', '02.99');
INSERT INTO public."DocumentType" VALUES ('7466d731-13c1-4fdc-92d1-2ef5b0d7ac66', 'Заключение государственной экспертизы запасов полезных ископаемых', '02.09');
INSERT INTO public."DocumentType" VALUES ('80fd29f2-6332-4086-b68a-31e3de92acb5', 'Заключение государственной экспертизы запасов подземных вод', '02.08');
INSERT INTO public."DocumentType" VALUES ('a9140e93-87d6-4305-ba1f-1df20e0b4e55', 'Заключение технологического и ценового аудита обоснования инвестиций', '02.07');
INSERT INTO public."DocumentType" VALUES ('a251c0ae-7beb-41d1-afbc-45cfa912bca9', 'Сводное заключение о проведении публичного технологического аудита крупного инвестиционного проекта с государственным участием', '02.06');
INSERT INTO public."DocumentType" VALUES ('657569bf-886d-4733-8dcd-d3d2cb44248b', 'Заключение государственной историко-культурной экспертизы', '02.05');
INSERT INTO public."DocumentType" VALUES ('b8f2e5ef-386a-43d2-8eae-4e78227d952f', 'Заключение государственной экологической экспертизы', '02.04');
INSERT INTO public."DocumentType" VALUES ('0f56d519-c95e-4626-a1eb-a2b02792d6ff', 'Заключение по результатам оценки соответствия в рамках экспертного сопровождения', '02.02');
INSERT INTO public."DocumentType" VALUES ('ba69b2c5-ab8c-4a3c-8bb1-8f5119b5c455', 'Заключение экспертизы проектной документации и/или результатов инженерных изысканий, выданное ранее в отношении этого же объекта', '02.01');
INSERT INTO public."DocumentType" VALUES ('b0f9dcde-3657-434d-8110-ba98dcb06bc8', 'Иные документы', '03.99');
INSERT INTO public."DocumentType" VALUES ('ffaa3d93-056c-42c7-a117-ef3faa6e2ed8', 'Согласование при осуществлении строительства помещений и сооружений, необходимых для организации пограничного, таможенного и иных видов контроля в пункте пропуска через Государственную границу', '03.06');
INSERT INTO public."DocumentType" VALUES ('78307f90-3812-4fba-9e70-f0a97ed91098', 'Согласование включения в границы территории, подлежащей 96 комплексному развитию по инициативе правообладателей земельных участков, для размещения объектов коммунальной, транспортной, социальной инфраструктур, находящихся в государственной и (или) муниципальной собственности и не обремененных правами третьих лиц', '03.05');
INSERT INTO public."DocumentType" VALUES ('a3091d05-2f1c-466c-9a84-dc0462497b60', 'Проект межевания территории', '03.04');
INSERT INTO public."DocumentType" VALUES ('2466e31c-4b08-4457-9989-e0339e7e94e6', 'Проект планировки территории', '03.03');
INSERT INTO public."DocumentType" VALUES ('830e14fe-04a5-4472-8e75-2727e7c5ee4c', 'Градостроительный план земельного участка', '03.02');
INSERT INTO public."DocumentType" VALUES ('a42c0e6b-417c-4314-ba84-6237df9017ff', 'Документ территориального планирования', '03.01');
INSERT INTO public."DocumentType" VALUES ('0f08cbee-8bdf-43d7-a121-a29107716c02', 'Иные документы', '04.99');
INSERT INTO public."DocumentType" VALUES ('2ac0b4d3-6932-44ab-99a6-fd374223d7bb', 'Технические условия на перенос и переустройство линий связи и сооружений связи', '04.03');
INSERT INTO public."DocumentType" VALUES ('a8664cc0-1114-4059-8c99-44f807d04a99', 'Документ о согласовании отступлений от положений технических условий', '04.02');
INSERT INTO public."DocumentType" VALUES ('f4f73562-0ec4-43b6-acfc-59e9e06e93f1', 'Технические условия на подключение объекта капитального строительства к сетям инженерно технического обеспечения', '04.01');
INSERT INTO public."DocumentType" VALUES ('f5d93da7-151d-46d9-bd26-4e77f69c5186', 'Иные задания', '05.99');
INSERT INTO public."DocumentType" VALUES ('7f414f4f-26b6-4e37-a7b5-84f23f2cec44', 'Задание на проектирование', '05.03');
INSERT INTO public."DocumentType" VALUES ('2ec806b6-ab63-4842-b550-25d2fd2b044f', 'Программа инженерных изысканий', '05.02');
INSERT INTO public."DocumentType" VALUES ('35868ae8-9387-4308-beab-fdd7f2a1fb0e', 'Задание на проведение инженерных изысканий', '05.01');
INSERT INTO public."DocumentType" VALUES ('ad2fd23d-278f-40ff-9f9f-e57d8f38acf5', 'Иной документ', '06.99');
INSERT INTO public."DocumentType" VALUES ('93196fa9-d057-4009-9cb2-6295a47e1e40', 'Локальные обследования загрязнения грунтов и грунтовых вод', '06.11');
INSERT INTO public."DocumentType" VALUES ('4ab34883-5937-430f-9401-05adf7bacc75', 'Разведка грунтовых строительных материалов', '06.10');
INSERT INTO public."DocumentType" VALUES ('8dcd5880-8c66-43a0-95bc-d364def72053', 'Локальный мониторинг компонентов окружающей среды', '06.09');
INSERT INTO public."DocumentType" VALUES ('2417d8b3-1dc2-4333-bc95-e1c6fa3ad0c2', 'Поиск и разведка подземных вод для целей водоснабжения', '06.08');
INSERT INTO public."DocumentType" VALUES ('4f33fefe-f5b3-4e74-8e0e-10c79a173999', 'Обследования состояния грунтов оснований зданий и сооружений, их строительных конструкций', '06.07');
INSERT INTO public."DocumentType" VALUES ('65f04792-8d7c-4a7b-8059-c2a3d9038f91', 'Геотехнические исследования', '06.06');
INSERT INTO public."DocumentType" VALUES ('fa71d14e-860f-43ae-b158-f0c3a2a7791b', 'Инженерно-геотехнические изыскания', '06.05');
INSERT INTO public."DocumentType" VALUES ('43b3e397-fede-4873-a0d1-230680fb99d0', 'Инженерно-экологические изыскания', '06.04');
INSERT INTO public."DocumentType" VALUES ('f0c8b57f-903c-4c75-96d5-444a641c74f1', 'Инженерно-гидрометеорологические изыскания', '06.03');
INSERT INTO public."DocumentType" VALUES ('bd8417f1-3b8b-43d5-a22a-a13226dd4232', 'Инженерно-геологические изыскания', '06.02');
INSERT INTO public."DocumentType" VALUES ('38619e1a-def1-431e-ada5-96e32f7f8b99', 'Инженерно-геодезические изыскания', '06.01');
INSERT INTO public."DocumentType" VALUES ('3886115b-c929-4668-b3ce-486477dfdd66', 'Раздел 9. «Мероприятия по обеспечению пожарной безопасности» (действовал до 01.09.2022)', '07.15');
INSERT INTO public."DocumentType" VALUES ('f677ca7e-3fe7-40ee-9a12-a74b80fc434a', 'Раздел 8. «Перечень мероприятий по охране окружающей среды» (действовал до 01.09.2022)', '07.14');
INSERT INTO public."DocumentType" VALUES ('73bd1c1c-5146-4d84-862a-79b599401c13', 'Раздел 7. «Проект организации работ по сносу или демонтажу объектов капитального строительства» (действовал до 01.09.2022)', '07.13');
INSERT INTO public."DocumentType" VALUES ('4fc83157-93f3-4e96-9e5a-2ea5081cb055', 'Раздел 6. «Проект организации строительства» (действовал до 01.09.2022)', '07.12');
INSERT INTO public."DocumentType" VALUES ('d9d5338c-a057-4bf5-ba52-7f5abd175c15', 'Раздел 5. Подраздел «Технологические решения» (действовал до 01.09.2022)', '07.11');
INSERT INTO public."DocumentType" VALUES ('8cbfc191-5507-450b-825d-dec2d1f862cb', 'Раздел 5. Подраздел «Система газоснабжения» (действовал до 01.09.2022)', '07.10');
INSERT INTO public."DocumentType" VALUES ('3777ce05-2e17-4805-bb7d-c238a4f52d72', 'Раздел 5. Подраздел «Сети связи» (действовал до 01.09.2022)', '07.09');
INSERT INTO public."DocumentType" VALUES ('3f485934-4a56-4a4b-8afe-1e4eaaa56981', 'Раздел 5. Подраздел «Отопление, вентиляция и кондиционирование воздуха, тепловые сети» (действовал до 01.09.2022)', '07.08');
INSERT INTO public."DocumentType" VALUES ('3838a134-445b-40e0-b4b1-512fc9cfe59c', 'Раздел 5. Подраздел «Система водоотведения» (действовал до 01.09.2022)', '07.07');
INSERT INTO public."DocumentType" VALUES ('7e70692c-dd0d-4156-9940-76cc91384f34', 'Раздел 5. Подраздел «Система водоснабжения» (действовал до 01.09.2022)', '07.06');
INSERT INTO public."DocumentType" VALUES ('4be8b365-7123-4a97-bcb8-84b62353292c', 'Раздел 5. Подраздел «Система электроснабжения» (действовал до 01.09.2022)', '07.05');
INSERT INTO public."DocumentType" VALUES ('6a1395fa-3777-42dd-b795-a4df5fa96441', 'Раздел 4. «Конструктивные и объемно-планировочные решения» (действовал до 01.09.2022)', '07.04');
INSERT INTO public."DocumentType" VALUES ('6c8f11d8-568b-4fed-92d1-82d3f11104fe', 'Раздел 3. «Архитектурные решения» (действовал до 01.09.2022)', '07.03');
INSERT INTO public."DocumentType" VALUES ('407c6333-3475-42c5-9229-e4b0a145985b', 'Раздел 2. «Схема планировочной организации земельного участка» (действовал до 01.09.2022)', '07.02');
INSERT INTO public."DocumentType" VALUES ('9ece4097-fcb5-457c-818d-df1afd859c4b', 'Раздел 1. «Пояснительная записка» (действовал до 01.09.2022)', '07.01');
INSERT INTO public."DocumentType" VALUES ('e1268432-7ac0-4f96-8222-7d353d60df21', 'Проектная документация. Раздел 5. Подраздел «Отопление, вентиляция и кондиционирование воздуха, тепловые сети» (действует с 01.09.2022)', '07.27');
INSERT INTO public."DocumentType" VALUES ('ba91a772-7e29-477a-b134-b790651ac115', 'Проектная документация. Раздел 5. Подраздел «Система водоотведения» (действует с 01.09.2022)', '07.26');
INSERT INTO public."DocumentType" VALUES ('59465ef1-5aa5-4c18-add6-bbe01dc9a2ec', 'Проектная документация. Раздел 5. Подраздел «Система водоснабжения» (действует с 01.09.2022)', '07.25');
INSERT INTO public."DocumentType" VALUES ('204ca6ae-2a54-4160-ba76-351be7c27c2f', 'Проектная документация. Раздел 5. Подраздел «Система электроснабжения» (действует с 01.09.2022)', '07.24');
INSERT INTO public."DocumentType" VALUES ('53eceee7-5c5c-4abd-b3d6-289285e8088a', 'Проектная документация. Раздел 4. «Конструктивные решения» (действует с 01.09.2022)', '07.23');
INSERT INTO public."DocumentType" VALUES ('138bd829-91c7-4e50-96fc-5f479189854d', 'Проектная документация. Раздел 3. «Объемно-планировочные и архитектурные решения» (действует с 01.09.2022)', '07.22');
INSERT INTO public."DocumentType" VALUES ('31405afe-e274-4bc5-95c3-248f25460166', 'Проектная документация. Раздел 2. «Схема планировочной организации земельного участка» (действует с 01.09.2022)', '07.21');
INSERT INTO public."DocumentType" VALUES ('b0073c24-d1aa-4c14-9d2d-05ff7130141d', 'Проектная документация. Раздел 1. «Пояснительная записка» (действует с 01.09.2022)', '07.20');
INSERT INTO public."DocumentType" VALUES ('307bb30d-5785-4040-971e-2037c17c982a', 'Раздел 12. «Иная документация в случаях, предусмотренных федеральными законами» (действовал до 01.09.2022)', '07.19');
INSERT INTO public."DocumentType" VALUES ('307a55d5-df75-4c34-8c90-6e5f30382cb5', 'Раздел 11. «Смета на строительство объектов капитального строительства» (действовал до 01.09.2022)', '07.18');
INSERT INTO public."DocumentType" VALUES ('850bc1c2-6b96-4f2d-a189-fd6019cef9ec', 'Раздел 10.1. «Мероприятия по обеспечению соблюдения требований энергетической эффективности и требований оснащенности зданий, строений и сооружений приборами учета используемых энергетических ресурсов» (действовал до 01.09.2022)', '07.17');
INSERT INTO public."DocumentType" VALUES ('8d1210d9-d39e-4445-b0e0-05ffb1f5e7dd', 'Раздел 10. «Мероприятия по обеспечению доступа инвалидов» (действовал до 01.09.2022)', '07.16');
INSERT INTO public."DocumentType" VALUES ('75f414b2-c2f4-4975-9406-c5716688e2a3', 'Проектная документация. Раздел 13. «Иная документация в случаях, предусмотренных законодательными и иными нормативными правовыми актами Российской Федерации» (действует с 01.09.2022', '07.37');
INSERT INTO public."DocumentType" VALUES ('f593817c-24f9-45ac-8c2b-45dcd48646be', 'Проектная документация. Раздел 12. «Смета на строительство, реконструкцию, капитальный ремонт, снос объекта капитального строительства» (действует с 01.09.2022)', '07.36');
INSERT INTO public."DocumentType" VALUES ('38b65c7a-d585-474a-9c5c-c1ca983144ec', 'Проектная документация. Раздел 11. «Мероприятия по обеспечению доступа инвалидов к объекту капитального строительства» (действует с 01.09.2022)', '07.35');
INSERT INTO public."DocumentType" VALUES ('03e3186a-dea0-4ed6-b9ef-b687891bc9a5', 'Проектная документация. Раздел 10. «Требования к обеспечению безопасной эксплуатации объектов капитального строительства» (действует с 01.09.2022)', '07.34');
INSERT INTO public."DocumentType" VALUES ('9ba3fdd1-9256-4464-9a2d-3bf050a6d004', 'Проектная документация. Раздел 9. «Мероприятия по обеспечению пожарной безопасности» (действует с 01.09.2022)', '07.33');
INSERT INTO public."DocumentType" VALUES ('50443630-4a4f-4546-bd12-12ed4f5706bd', 'Проектная документация. Раздел 8. «Мероприятия по охране окружающей среды» (действует с 01.09.2022)', '07.32');
INSERT INTO public."DocumentType" VALUES ('6c7862e3-b4b7-43c8-a77f-0aaa7171a20c', 'Проектная документация. Раздел 7. «Проект организации строительства» (действует с 01.09.2022)', '07.31');
INSERT INTO public."DocumentType" VALUES ('dbd54e5d-2053-46bf-b9b6-dd0ffdfbcacd', 'Проектная документация. Раздел 6. «Технологические решения» (действует с 01.09.2022)', '07.30');
INSERT INTO public."DocumentType" VALUES ('b2cd2209-256b-4818-9e67-9c05d6daac4c', 'Проектная документация. Раздел 5. Подраздел «Система газоснабжения» (действует с 01.09.2022)', '07.29');
INSERT INTO public."DocumentType" VALUES ('346e4d93-a9f2-409f-93e3-63660d12bc35', 'Проектная документация. Раздел 5. Подраздел «Сети связи» (действует с 01.09.2022)', '07.28');
INSERT INTO public."DocumentType" VALUES ('c91c4f55-e459-4fc6-9e50-814ca6a34dea', 'Проектная документация. Линейный объект. Раздел 5. «Проект организации строительства» (действует с 01.09.2022)', '08.15');
INSERT INTO public."DocumentType" VALUES ('de045957-fe83-4195-99dd-b82ce41b15e8', 'Проектная документация. Линейный объект. Раздел 4. «Здания, строения и сооружения, входящие в инфраструктуру линейного объекта» (действует с 01.09.2022)', '08.14');
INSERT INTO public."DocumentType" VALUES ('8c3d1294-1aa1-40b8-a1c4-e476ae5d3ccf', 'Проектная документация. Линейный объект. Раздел 3. «Технологические и конструктивные решения линейного объекта. Искусственные сооружения» (действует с 01.09.2022)', '08.13');
INSERT INTO public."DocumentType" VALUES ('99c5bf66-1ab0-4865-b573-3e71802effb0', 'Проектная документация. Линейный объект. Раздел 2. «Проект полосы отвода» (действует с 01.09.2022)', '08.12');
INSERT INTO public."DocumentType" VALUES ('06780935-e04b-4f3e-8ef0-43695ac53855', 'Проектная документация. Линейный объект. Раздел 1. «Пояснительная записка» (действует с 01.09.2022)', '08.11');
INSERT INTO public."DocumentType" VALUES ('56e9f0a7-c369-4d6c-8865-1bc7ab1fb24f', 'Раздел 10. «Иная документация в случаях, предусмотренных федеральными законами» (действовал до 01.09.2022)', '08.10');
INSERT INTO public."DocumentType" VALUES ('85d5e7b6-d2b6-429f-865f-8f84baa34e1c', 'Раздел 9. «Смета на строительство» (действовал до 01.09.2022)', '08.09');
INSERT INTO public."DocumentType" VALUES ('369fd1ba-1bc2-4bce-89bd-b843c213fae1', 'Раздел 8. «Мероприятия по обеспечению пожарной безопасности» (действовал до 01.09.2022)', '08.08');
INSERT INTO public."DocumentType" VALUES ('72942e7c-87aa-4308-8b4a-ecc566398f31', 'Раздел 7. «Мероприятия по охране окружающей среды» (действовал до 01.09.2022)', '08.07');
INSERT INTO public."DocumentType" VALUES ('2191ccf5-3adc-4ab4-8026-47f6f7c43103', 'Раздел 6. «Проект организации работ по сносу (демонтажу) линейного объекта» (действовал до 01.09.2022)', '08.06');
INSERT INTO public."DocumentType" VALUES ('a4dbbeb9-982a-4f60-b5c7-b06b159f679e', 'Раздел 5. «Проект организации строительства» (действовал до 01.09.2022)', '08.05');
INSERT INTO public."DocumentType" VALUES ('85cacf0a-b63f-48fb-87d8-810b5e19ce01', 'Раздел 4. «Здания, строения и сооружения, входящие в инфраструктуру линейного объекта» (действовал до 01.09.2022)', '08.04');
INSERT INTO public."DocumentType" VALUES ('204542d1-9e46-442a-b6e0-e9d5ddacd180', 'Раздел 3. «Технологические и конструктивные решения линейного объекта. Искусственные сооружения» (действовал до 01.09.2022)', '08.03');
INSERT INTO public."DocumentType" VALUES ('1228f485-3f64-4032-aa9c-dfc5404f161e', 'Раздел 2. «Проект полосы отвода» (действовал до 01.09.2022)', '08.02');
INSERT INTO public."DocumentType" VALUES ('152e5e27-de45-425d-accd-2065cb083034', 'Раздел 1. «Пояснительная записка» (действовал до 01.09.2022)', '08.01');
INSERT INTO public."DocumentType" VALUES ('8782d611-c4b5-4310-9989-22b292952d52', 'Проектная документация. Линейный объект. Раздел 10. «Иная документация в случаях, предусмотренных законодательными и иными нормативными правовыми актами Российской Федерации» (действует с 01.09.2022)', '08.20');
INSERT INTO public."DocumentType" VALUES ('7b4302c9-e7aa-4c6f-b341-54249e31f3d0', 'Проектная документация. Линейный объект. Раздел 9. «Смета на строительство, реконструкцию, капитальный ремонт, снос объекта капитального строительства» (действует с 01.09.2022)', '08.19');
INSERT INTO public."DocumentType" VALUES ('ba48d680-f6b7-4aa7-ac0a-f8f3353af0d4', 'Проектная документация. Линейный объект. Раздел 8. «Требования к обеспечению безопасной эксплуатации линейного объекта» (действует с 01.09.2022)', '08.18');
INSERT INTO public."DocumentType" VALUES ('d8fa4bcb-0cc4-4f33-a5e5-f6b8541564ac', 'Проектная документация. Линейный объект. Раздел 7. «Мероприятия по обеспечению пожарной безопасности» (действует с 01.09.2022)', '08.17');
INSERT INTO public."DocumentType" VALUES ('e4b5388f-b1d5-40ab-885b-6425971ad0a5', 'Проектная документация. Линейный объект. Раздел 6. «Мероприятия по охране окружающей среды» (действует с 01.09.2022)', '08.16');
INSERT INTO public."DocumentType" VALUES ('6dbb534f-eb88-4d8e-ad12-76ee702a9fd4', 'Иной документ', '09.99');
INSERT INTO public."DocumentType" VALUES ('86762d23-4372-403d-95ca-28c6949a433c', 'Сопроводительное письмо заявителя с откорректированной проектной документацией', '09.02');
INSERT INTO public."DocumentType" VALUES ('b6e914e3-5400-42c4-ace5-c34db276a246', 'Уведомление о выявлении недостатков', '09.01');
INSERT INTO public."DocumentType" VALUES ('918ec639-a5c1-4fa7-abb8-980cbea121ec', 'Иной документ', '10.99');
INSERT INTO public."DocumentType" VALUES ('949391fe-cc36-406e-96cd-570518a3a9bc', 'Выписка из реестра членов саморегулируемой организации', '10.01');
INSERT INTO public."DocumentType" VALUES ('434f1c5f-cf13-437d-992a-08d02f3c2b0a', 'Иной документ', '11.99');
INSERT INTO public."DocumentType" VALUES ('cc8b2678-0a4e-4b3d-a529-3dbe9bbb0b88', 'Прайс-лист', '11.06');
INSERT INTO public."DocumentType" VALUES ('8771e485-525c-4036-b1f3-dc6ee22f410c', 'Коньюктурный анализ', '11.05');
INSERT INTO public."DocumentType" VALUES ('b77e7b77-4846-437e-88e8-82dad73f89b3', 'Решение о разработке и применении индивидуальных сметных нормативов', '11.04');
INSERT INTO public."DocumentType" VALUES ('47b04be8-be3b-4f08-816f-363648255d3f', 'Акт, содержащий перечень дефектов оснований, строительных конструкций, систем инженерно-технического обеспечения и сетей инженерно-технического обеспечения', '11.03');
INSERT INTO public."DocumentType" VALUES ('e801f7d7-e471-49b2-93f1-749c7994a014', 'Решение по объекту капитального строительства', '11.02');
INSERT INTO public."DocumentType" VALUES ('c1910176-7b0e-4d94-b3e2-692d9b8c3f8d', 'Ведомость объемов работ', '11.01');
INSERT INTO public."DocumentType" VALUES ('3e827794-8d59-4bec-ac55-90b6c11ec610', 'Иные документы', '12.99');
INSERT INTO public."DocumentType" VALUES ('075d1b21-0816-4cad-b641-b68b6ef11509', 'Документ, подтверждающий аналогичность', '12.03');
INSERT INTO public."DocumentType" VALUES ('5aac1e59-7e83-4c10-98bf-160201811ca2', 'Справка с указанием разделов, которые не подвергались изменению', '12.02');
INSERT INTO public."DocumentType" VALUES ('ad16257e-4f26-4cbb-979e-01838046e58e', 'Положительное заключение экспертизы в отношении экономически эффективной (типовой) проектной документации повторного использования', '12.01');
INSERT INTO public."DocumentType" VALUES ('f36e2eeb-78e1-491e-b93a-5f7dca1afce1', 'Проект организации работ по сносу объекта капитального строительства', '13.01');
INSERT INTO public."DocumentType" VALUES ('ea650bb7-549a-4923-b7dc-aba9e3e3b93a', 'Смета на снос объекта капитального строительства', '13.02');
INSERT INTO public."DocumentType" VALUES ('6072c9e4-a33a-44ff-bb39-1cb2df6c6732', 'Акт (решение) собственника здания (сооружения, строения) о выведении из эксплуатации и ликвидации объекта капитального строительства', '13.03');
INSERT INTO public."DocumentType" VALUES ('f14afe46-2da5-42a8-97e9-219e285e81ef', 'Решение федерального органа исполнительной власти, органа исполнительной власти субъекта Российской Федерации или органа местного самоуправления о признании многоквартирного дома аварийным и подлежащим сносу', '13.04');
INSERT INTO public."DocumentType" VALUES ('34495a3e-ff89-4b5a-aa8e-a38cabd45756', 'Результаты и материалы обследования объекта капитального строительства в соответствии с требованиями технических регламентов, санитарно-эпидемиологическими требованиями, требованиями в области охраны окружающей среды, требованиями безопасности деятельности в области использования атомной энергии, требованиями к осуществлению деятельности в области промышленной безопасности', '13.05');
INSERT INTO public."DocumentType" VALUES ('ff988842-de7b-4da5-953e-346ca4743f97', 'Документ, подтверждающий передачу проекта организации работ по сносу объекта капитального строительства застройщику, техническому заказчику или лицу, обеспечившему выполнение инженерных изысканий и (или) подготовку проектной документации', '13.06');
INSERT INTO public."DocumentType" VALUES ('95b3ca63-048c-4af4-9a31-d78978daebd3', 'Иной документ', '13.99');
INSERT INTO public."DocumentType" VALUES ('d560ef58-2503-46c1-a243-0b7448179103', 'Иная программа', '14.99');
INSERT INTO public."DocumentType" VALUES ('dd30e20a-794b-41e4-9cb1-b8c1458b0a6e', 'Ведомственная целевая программа', '14.04');
INSERT INTO public."DocumentType" VALUES ('1e1e7594-1e17-414d-a9ee-85881b5805a8', 'Программа развития муниципального образования', '14.03');
INSERT INTO public."DocumentType" VALUES ('9a69d734-fe43-42b2-9a19-f9c73fe2244c', 'Программа развития субъекта Российской Федерации', '14.02');
INSERT INTO public."DocumentType" VALUES ('91cffcad-58e2-42be-8e2c-c4d72a9e8360', 'Федеральная целевая программа', '14.01');
INSERT INTO public."DocumentType" VALUES ('0a3d5327-ceb4-4097-b660-320a7eeed72f', 'Решение иного лица', '15.99');
INSERT INTO public."DocumentType" VALUES ('cdc3c893-9a10-4cf7-9fdd-4eb05ee4f184', 'Решение застройщика', '15.08');
INSERT INTO public."DocumentType" VALUES ('779b2e2d-adb1-4e24-aa49-83d541ddb865', 'Решение по объекту капитального строительства, принятое в порядке, установленном методикой, приведенной в приложении к соответствующей федеральной целевой программе, определяющей порядок детализации мероприятий (укрупненных инвестиционных проектов), содержащее информацию об объекте капитального строительства, входящем в мероприятие (укрупненный инвестиционный проект)', '15.07');
INSERT INTO public."DocumentType" VALUES ('4f320717-5512-448f-a53c-1ec8382c337e', 'Решение руководителя государственной компании и корпорации об осуществлении капитальных вложений в объект капитального строительства', '15.06');
INSERT INTO public."DocumentType" VALUES ('b46dad23-f3ea-49e6-9e2e-1c2097eb63f9', 'Решение главного распорядителя средств федерального бюджета о подготовке и реализации бюджетных инвестиций, о предоставлении субсидий на осуществление капитальных вложений в объект капитального строительства', '15.05');
INSERT INTO public."DocumentType" VALUES ('6262f4e7-9484-4b30-ba06-c74d0d34345e', 'Муниципальный правовой акт местной администрации муниципального образования', '15.04');
INSERT INTO public."DocumentType" VALUES ('83cada9b-144c-47d5-beab-b42234118e35', 'Нормативный правовой акт высшего органа исполнительной власти субъекта Российской Федерации', '15.03');
INSERT INTO public."DocumentType" VALUES ('89cf7239-5dc3-4416-8466-afd2269d93e1', 'Нормативный правовой акт Правительства Российской Федерации', '15.02');
INSERT INTO public."DocumentType" VALUES ('160b232e-6a79-4e79-90ec-58ada34bd7bc', 'Решение Президента Российской федерации', '15.01');
INSERT INTO public."DocumentType" VALUES ('fbe7b751-32f9-438e-b07f-715ad1baff3d', 'Иные договоры', '16.99');
INSERT INTO public."DocumentType" VALUES ('18702112-aff5-404a-9e89-23b0130eb4f7', 'Соглашение о разделе продукции', '16.02');
INSERT INTO public."DocumentType" VALUES ('226f5d36-c2cb-4542-98e7-b4d639df4e56', 'Международный договор', '16.01');
INSERT INTO public."DocumentType" VALUES ('0c3751cc-88e9-4de1-807f-63b191c6b20a', 'Иной правоустанавливающий документ', '17.99');
INSERT INTO public."DocumentType" VALUES ('f67573ff-590f-452a-a4e5-2bc8d8d44966', 'Выписка из Единого государственного реестра недвижимости', '17.01');
INSERT INTO public."DocumentType" VALUES ('c430d6d0-e695-4009-bd65-67d463c05811', 'Иные документы', '18.99');
INSERT INTO public."DocumentType" VALUES ('ea5828f6-daf3-4915-ba9e-58c86994fa2a', 'Документ о регистрации в государственном реестре опасных производственных объектов', '18.03');
INSERT INTO public."DocumentType" VALUES ('15ebe528-ec9f-42a5-a5d5-3cc801d805a1', 'Положительное заключение экспертизы промышленной безопасности обоснования безопасности опасного производственного объекта, внесенное в реестр заключений экспертизы промышленной безопасности', '18.02');
INSERT INTO public."DocumentType" VALUES ('e6653bb7-322e-4359-928a-31bbd5c64b90', 'Обоснование безопасности опасного производственного объекта в случаях, предусмотренных частью 4 статьи 3 Федерального закона «О промышленной безопасности опасных производственных объектов»', '18.01');
INSERT INTO public."DocumentType" VALUES ('63ec0ef8-8e69-4cfd-8f60-12896340301a', 'Иные документы', '19.99');
INSERT INTO public."DocumentType" VALUES ('184c2f76-67c5-404c-97ed-0c0fc4944106', 'Технические требования и условия, подлежащие обязательному исполнению при подготовке проектной документации в целях реконструкции, капитального ремонта существующих линейного объекта или линейных объектов, а также при осуществлении таких реконструкций, капитального ремонта', '19.03');
INSERT INTO public."DocumentType" VALUES ('dd3947be-3d41-43a9-93f6-03dcb39ff461', 'Документ о согласовании отступлений от положений специальных технических условий', '19.02');
INSERT INTO public."DocumentType" VALUES ('8f26809d-bc14-4784-839e-4df1d9426d78', 'Специальные технические условия', '19.01');
INSERT INTO public."DocumentType" VALUES ('822fa3b6-bb99-4968-9050-9391f0796562', 'Иные разрешения', '20.99');
INSERT INTO public."DocumentType" VALUES ('7e483581-a776-4231-b4d2-ecf2e665e003', 'Разрешение на установку радиопередающих средств на высотных зданиях', '20.07');
INSERT INTO public."DocumentType" VALUES ('953d623d-1d07-4a8f-aaa6-595c94b0cf53', 'Разрешение на застройку земельных участков, которые расположены за границами населенных пунктов и находятся на площадях залегания полезных ископаемых, а также на размещение за границами населенных пунктов в местах залегания полезных ископаемых подземных сооружений в пределах горного отвода', '20.06');
INSERT INTO public."DocumentType" VALUES ('55b4bbe8-ca59-4c87-82b3-84615a81876e', 'Разрешение на отклонение от предельных параметров разрешенного строительства, реконструкции объектов капитального строительства', '20.05');
INSERT INTO public."DocumentType" VALUES ('c02efacd-8c0e-4857-b567-03c54f2624fa', 'Разрешение на условно разрешенный вид использования земельного участка или объекта капитального строительства', '20.04');
INSERT INTO public."DocumentType" VALUES ('5f9e3615-1ed6-4e22-aa16-f0e6bb5ed3cf', 'Акт освидетельствования проведения основных работ по строительству, реконструкции', '20.03');
INSERT INTO public."DocumentType" VALUES ('447b8aac-6692-4185-b087-78f1c66144ca', 'Разрешение на ввод объектов в эксплуатацию', '20.02');
INSERT INTO public."DocumentType" VALUES ('93c2cb1f-047f-4c10-9ba7-a9537bd40991', 'Разрешение на строительство', '20.01');
INSERT INTO public."DocumentType" VALUES ('5975ea8e-49b2-427d-8a02-bf1540baacf5', 'Иные документы', '21.99');
INSERT INTO public."DocumentType" VALUES ('ded27202-ab18-45ea-9c5e-2ff51ea2b7e6', 'Решение об установлении, изменении или о прекращении существования санитарно-защитной зоны', '21.13');
INSERT INTO public."DocumentType" VALUES ('2f24ff8e-cf97-4dac-9e4b-8f92ad89c405', 'Сведения о наличии и месторасположении в районе размещения проектируемого объекта зон санитарной охраны источников водоснабжения (поверхностных и подземных)', '21.12');
INSERT INTO public."DocumentType" VALUES ('a4a0e489-83af-4873-842f-690872b9c3f4', 'Сведения о размерах водоохранных зон и прибрежных защитных полос, затрагиваемых в ходе строительства, поверхностных водных объектов', '21.11');
INSERT INTO public."DocumentType" VALUES ('23553304-bd3c-4470-8a38-93a6f219772f', 'Согласование плана предупреждения и ликвидации разливов нефти и нефтепродуктов', '21.10');
INSERT INTO public."DocumentType" VALUES ('194ba77e-2d12-4a57-be36-00a29d210c68', 'Документ об утверждении нормативов образования отходов производства и потребления и лимитов на их размещение', '21.09');
INSERT INTO public."DocumentType" VALUES ('9ee3f857-eac2-4247-9fe3-0b3e90a259e3', 'Документ о согласовании сооружения линий связи, электропередач, трубопроводов, дорог и других объектов на мелиорируемых (мелиорированных) землях', '21.08');
INSERT INTO public."DocumentType" VALUES ('a1d96dca-de91-45c4-bfd1-14044407de4b', 'Санитарно-эпидемиологическое заключение о соответствии санитарным правилам проекта зон санитарной охраны источника хозяйственно-питьевого водоснабжения', '21.07');
INSERT INTO public."DocumentType" VALUES ('d0f021c3-9ff9-4f8a-baef-e16a1ff79aab', 'Заключение об отсутствии полезных ископаемых в недрах под участком предстоящей застройки', '21.06');
INSERT INTO public."DocumentType" VALUES ('f918b9e9-4a49-4f1f-bbcb-f947f3ceeda1', 'Согласование проектной документации в отношении строительства и эксплуатации в пластах горных пород различных видов хранилищ углеводородного сырья и продуктов его переработки', '21.05');
INSERT INTO public."DocumentType" VALUES ('d242901e-9aca-4418-a0a8-259e9ff1b759', 'Заключение о согласовании строительства и реконструкции объектов капитального строительства, внедрения новых технологических процессов и осуществления иной деятельности, оказывающей воздействие на водные биологические ресурсы и среду их обитания', '21.04');
INSERT INTO public."DocumentType" VALUES ('1ea959f4-4561-4b3e-b409-45f8d4170cc1', 'Лицензия на пользование недрами', '21.03');
INSERT INTO public."DocumentType" VALUES ('f082d85e-8893-4f90-a5df-edcbbc42e127', 'Горноотводный акт с планом границ горного отвода или его копия', '21.02');
INSERT INTO public."DocumentType" VALUES ('1d90b616-cadc-4c3e-a4d4-4210f4c2e89e', 'Расчет нормативов допустимых выбросов, нормативов допустимых сбросов', '21.01');
INSERT INTO public."DocumentType" VALUES ('3c175d89-b4e3-4934-a935-a4142971a740', 'Иные документы', '22.99');
INSERT INTO public."DocumentType" VALUES ('9ae5ff97-a808-4433-b7da-8890c56dd9e0', 'Сведения о зонах с особыми условиями использования территорий объектов инфраструктуры метрополитена', '22.05');
INSERT INTO public."DocumentType" VALUES ('eedf0215-d9dd-474b-a4ec-2c0add46c6bb', 'Решение об установлении приаэродромной территории', '22.04');
INSERT INTO public."DocumentType" VALUES ('a0df58b3-ba83-4794-8900-68e159b4ad5f', 'Решение о согласовании размещения объекта в границах полос воздушных подходов для аэродромов экспериментальной авиации, аэродромов государственной авиации, аэродромов гражданской авиации', '22.03');
INSERT INTO public."DocumentType" VALUES ('4b25cc55-df68-41ed-b381-3d4535f2578e', 'Согласование типов и конструкций устройств со специальными проходами, ограждающими опасные участки транспортных магистралей в местах концентрации объектов животного мира и на путях их миграции', '22.02');
INSERT INTO public."DocumentType" VALUES ('440c3953-5c0d-44bb-8c21-417208324c61', 'Сведения о согласовании предварительной категории строящегося объекта транспортной инфраструктуры с компетентным органом в области обеспечения транспортной безопасности', '22.01');
INSERT INTO public."DocumentType" VALUES ('71ca8be4-a76c-40c8-9d4f-b119c9bd1949', 'Иные документы', '23.99');
INSERT INTO public."DocumentType" VALUES ('0e8d90fb-39e8-4312-8447-8f3b53f39c2a', 'Согласование проектных решений раздела по обеспечению сохранности объектов культурного наследия либо проектной документации по реставрации и приспособлению объекта культурного наследия', '23.02');
INSERT INTO public."DocumentType" VALUES ('8ca1f713-ef8f-483b-b6d0-93db1160f4e4', 'Паспорт объекта культурного наследия', '23.01');
INSERT INTO public."DocumentType" VALUES ('263b56dc-61fb-439f-ad77-af194adf055a', 'Расчеты конструктивных, технологических и других решений, используемых в проектной документации', '24.01');
INSERT INTO public."DocumentType" VALUES ('c740df43-c30c-4e18-bf18-4276c90eb2b2', 'Сметные расчеты на отдельные виды затрат', '25.06');
INSERT INTO public."DocumentType" VALUES ('84442894-35ea-47a0-945f-d92abc08955c', 'Локальный сметный расчет', '25.05');
INSERT INTO public."DocumentType" VALUES ('2ef07dee-07d5-4d19-924b-e72b59ab6e58', 'Объектный сметный расчет', '25.04');
INSERT INTO public."DocumentType" VALUES ('8345c73f-f2bb-4a4d-9b0d-43e985cb384e', 'Сводный сметный расчет', '25.03');
INSERT INTO public."DocumentType" VALUES ('6c981de5-c746-4c5c-9fbf-752ad7c1fdee', 'Сводка затрат', '25.02');
INSERT INTO public."DocumentType" VALUES ('e5cac58e-e009-4f27-b911-2fbcbc7037da', 'Пояснительная записка к сметной документации', '25.01');
INSERT INTO public."DocumentType" VALUES ('f5e73615-ab5e-4411-a58e-f8f8833367d1', 'Оценка риска возникновения опасных природных процессов и явлений и (или) техногенных воздействий', '26.04');
INSERT INTO public."DocumentType" VALUES ('0c5facae-7abf-4742-80a4-67b18e764e04', 'Моделирование сценариев возникновения опасных природных процессов и явлений и (или) техногенных воздействий, в том числе при неблагоприятном сочетании опасных природных процессов и явлений и (или) техногенных воздействий', '26.03');
INSERT INTO public."DocumentType" VALUES ('1d02efcb-6858-493c-98d8-f513a72b65ad', 'Расчеты и (или) испытания, выполненные по сертифицированным или апробированным иным способом методикам', '26.02');
INSERT INTO public."DocumentType" VALUES ('6bf532f8-ad3a-4a6c-adee-ab874e145fa8', 'Результаты исследований', '26.01');
INSERT INTO public."DocumentType" VALUES ('f3b07d2f-b1ce-4920-bf99-c9cb5c011373', 'Иной документ', '99.99');
INSERT INTO public."DocumentType" VALUES ('899e39d8-6672-4d56-a0fe-a2b73acc1c27', 'Акт (решение) собственника здания (строения, сооружения), содержащий условия реконструкции, капитального ремонта или сноса объекта капитального строительства или его части', '99.03');
INSERT INTO public."DocumentType" VALUES ('1cd2ad3f-aadc-49dc-bec4-d2919059261c', 'Справка с описанием изменений, внесенных в проектную документацию и (или) результаты инженерных изысканий', '99.02');
INSERT INTO public."DocumentType" VALUES ('e2fc6221-7c27-4617-a78e-7c4fad0cb8d3', 'Документ, подтверждающий передачу проектной документации и (или) результатов инженерных изысканий застройщику (техническому заказчику)', '99.01');


--
-- Data for Name: EngineeringSurveyDocuments; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: EngineeringSurveyDocument; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ForeignOrganization; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: IP; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Organization; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ProjectDocumentationAuthors; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: SROMembership; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Author; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: BudgetLevel; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."BudgetLevel" VALUES ('a414752a-2d91-4bca-a4df-d46936fc42b7', 'Бюджет территориального государственного внебюджетного фонда', 'Бюджет территориального государственного внебюджетного фонда');
INSERT INTO public."BudgetLevel" VALUES ('14710818-47dc-48a9-bf3c-62824d44bc6c', 'Бюджет государственного внебюджетного фонда Российской Федерации', 'Бюджет государственного внебюджетного фонда Российской Федерации');
INSERT INTO public."BudgetLevel" VALUES ('839fc562-fd68-46a9-9d37-1fdd728af92b', 'Местный бюджет', 'Местный бюджет');
INSERT INTO public."BudgetLevel" VALUES ('d8e20242-0cca-47ea-b78a-09bca1e8d322', 'Бюджет субъекта Российской Федерации', 'Бюджет субъекта Российской Федерации');
INSERT INTO public."BudgetLevel" VALUES ('49cb556a-51bf-434c-8c03-deaf77be348b', 'Федеральный бюджет', 'Федеральный бюджет');


--
-- Data for Name: FinanceSources; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: BudgetSource; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Cell; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ChiefProjectEngineer; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ClimateConditions; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ClimateDistrict; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."ClimateDistrict" VALUES ('e1561862-086f-4588-a6e7-118b82307709', 'климатический подрайон IVГ', 'IVГ');
INSERT INTO public."ClimateDistrict" VALUES ('ab83a33b-dfa7-4fd4-9d7d-6b22412f0edf', 'климатический подрайон IVВ', 'IVВ');
INSERT INTO public."ClimateDistrict" VALUES ('ea9857f2-b6ab-4462-87af-a968b1056631', 'климатический подрайон IVБ', 'IVБ');
INSERT INTO public."ClimateDistrict" VALUES ('c85f32c7-3976-488e-a21e-6e6fcee404f7', 'климатический подрайон IVА', 'IVА');
INSERT INTO public."ClimateDistrict" VALUES ('ae39e8f6-050e-4313-a121-874fe5b44ce8', 'климатический район IV', 'IV');
INSERT INTO public."ClimateDistrict" VALUES ('62688286-9141-47d5-b8ee-d5298262e850', 'климатический подрайон IIIВ', 'IIIВ');
INSERT INTO public."ClimateDistrict" VALUES ('96e83979-129b-4fcb-8488-d9eb9f37ada7', 'климатический подрайон IIIБ', 'IIIБ');
INSERT INTO public."ClimateDistrict" VALUES ('8fd1a2fe-40f7-43bd-b186-d2ac006e2f64', 'климатический подрайон IIIА', 'IIIА');
INSERT INTO public."ClimateDistrict" VALUES ('c5984cc7-ccd7-478b-ab27-5eaa582a6794', 'климатический район III', 'III');
INSERT INTO public."ClimateDistrict" VALUES ('12ffbcd8-3ee7-44a8-b4f6-0630fc781e59', 'климатический подрайон IIГ', 'IIГ');
INSERT INTO public."ClimateDistrict" VALUES ('14d0febc-3035-470e-bace-8e299c7cecfe', 'климатический подрайон IIВ', 'IIВ');
INSERT INTO public."ClimateDistrict" VALUES ('cd600f84-cc3d-41e4-bc2c-a3c2021e545b', 'климатический подрайон IIБ', 'IIБ');
INSERT INTO public."ClimateDistrict" VALUES ('9e7c5647-0b99-4779-868a-b7bd80282697', 'климатический подрайон IIА', 'IIА');
INSERT INTO public."ClimateDistrict" VALUES ('e837e54e-7ed0-4d62-a52b-4514af319dcd', 'климатический район II', 'II');
INSERT INTO public."ClimateDistrict" VALUES ('e4845c89-6227-4a81-b027-844b636250cb', 'климатический подрайон IД', 'IД');
INSERT INTO public."ClimateDistrict" VALUES ('638701a8-3f96-424c-b964-79831526b7de', 'климатический подрайон IГ', 'IГ');
INSERT INTO public."ClimateDistrict" VALUES ('eff94f83-3d87-4000-88a2-957ba00293d3', 'климатический подрайон IВ', 'IВ');
INSERT INTO public."ClimateDistrict" VALUES ('4dd288ff-d8a5-468b-91cf-369be7f19f60', 'климатический подрайон IБ', 'IБ');
INSERT INTO public."ClimateDistrict" VALUES ('eeee3b1b-d2bf-4011-a253-6942925f7144', 'климатический подрайон IА', 'IА');
INSERT INTO public."ClimateDistrict" VALUES ('5d97afe1-7726-4bb7-9520-7896efb716b6', 'климатический район I', 'I');


--
-- Data for Name: ClimateConditionsClimateDistrict; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: GeologicalConditions; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."GeologicalConditions" VALUES ('c8596241-ba51-4ee5-9320-e7f5ee48635b', 'III (сложные)', 'III');
INSERT INTO public."GeologicalConditions" VALUES ('a05c7ac6-47a9-4026-a38c-dd6502d25e73', 'II (средней сложности)', 'II');
INSERT INTO public."GeologicalConditions" VALUES ('f5efee65-5dcf-47ab-857c-b004f791a307', 'I (простые)', 'I');


--
-- Data for Name: ClimateConditionsGeologicalConditions; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: SeismicActivity; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."SeismicActivity" VALUES ('6cc92419-8a49-4fc0-baac-6b8cb50b27b0', 'Более 9 баллов', '10');
INSERT INTO public."SeismicActivity" VALUES ('89d2bce8-58a6-41b1-8b0a-045ece5cce35', '9 баллов', '9');
INSERT INTO public."SeismicActivity" VALUES ('e36c004e-7420-45e9-9782-155210b7e00a', '8 баллов', '8');
INSERT INTO public."SeismicActivity" VALUES ('af38b368-f715-42ed-a77e-d45987098784', '7 баллов', '7');
INSERT INTO public."SeismicActivity" VALUES ('9ea379b1-d994-486e-9fe1-b15ddd7c5675', '6 баллов', '6');
INSERT INTO public."SeismicActivity" VALUES ('efefd108-19e4-4012-8c32-d2caeb920098', '5 и менее баллов', '5');


--
-- Data for Name: ClimateConditionsSeismicActivity; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: SnowDistrict; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."SnowDistrict" VALUES ('68eb30cf-57a5-4798-8d4c-9b89f17325c5', 'Снеговой район VIII', 'VIII');
INSERT INTO public."SnowDistrict" VALUES ('b7530ff6-9179-4d56-b0d8-b5bbe06ebd57', 'Снеговой район VII', 'VII');
INSERT INTO public."SnowDistrict" VALUES ('5859b705-bffe-4387-9bd5-bb4d3e20e233', 'Снеговой район VI', 'VI');
INSERT INTO public."SnowDistrict" VALUES ('9ba52318-4232-45ae-985e-79eaf02854cc', 'Снеговой район V', 'V');
INSERT INTO public."SnowDistrict" VALUES ('29333952-6c42-452d-8143-c4d55c72453b', 'Снеговой район IV', 'IV');
INSERT INTO public."SnowDistrict" VALUES ('89edb630-5a3b-47b5-94f8-1fd54dffb415', 'Снеговой район III', 'III');
INSERT INTO public."SnowDistrict" VALUES ('b37e9c20-5a91-45eb-b83c-f5bbb55f3d53', 'Снеговой район II', 'II');
INSERT INTO public."SnowDistrict" VALUES ('868bbeaa-14be-472f-b1cf-3f1ea1a10a1b', 'Снеговой район I', 'I');


--
-- Data for Name: ClimateConditionsSnowDistrict; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: WindDistrict; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."WindDistrict" VALUES ('7d819d2f-032f-4bd8-8678-c897a8570456', 'Ветровой район VI', 'VI');
INSERT INTO public."WindDistrict" VALUES ('6777b36f-00ba-4f60-9d5d-6e21bc219433', 'Ветровой район V', 'V');
INSERT INTO public."WindDistrict" VALUES ('950b280d-1c89-49c4-b1aa-a923948f1838', 'Ветровой район IV', 'IV');
INSERT INTO public."WindDistrict" VALUES ('61a7f084-46b5-4658-9a8d-ba8f03e2fb32', 'Ветровой район III', 'III');
INSERT INTO public."WindDistrict" VALUES ('1d726660-8147-40c4-b73e-227360631c56', 'Ветровой район II', 'II');
INSERT INTO public."WindDistrict" VALUES ('231b79b7-5cc2-4175-9bf4-9e1d1e82fac8', 'Ветровой район I', 'I');
INSERT INTO public."WindDistrict" VALUES ('a410d4cf-bb6c-4006-b2e5-4cbe1387c059', 'Ветровой район Iа', 'Iа');
INSERT INTO public."WindDistrict" VALUES ('265fb2c1-5a04-4f87-bace-9e7059739a6e', 'Ветровой район VII', 'VII');


--
-- Data for Name: ClimateConditionsWindDistrict; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Documents; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ExplanatoryNoteModifications; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Signers; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: UsedNorms; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ExplanatoryNote; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Model; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ObjectParts; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: TextBlock; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ComplexPart; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ConstractionType; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."ConstractionType" VALUES ('25348e04-616a-44e1-a834-347f591d3323', 'Сохранение объекта культурного наследия', '5');
INSERT INTO public."ConstractionType" VALUES ('f2b2576b-c8ef-4a24-8dec-81db4c1387ce', 'Снос', '4');
INSERT INTO public."ConstractionType" VALUES ('2b0248ce-6a13-4c72-bd22-020aeed2a900', 'Капитальный ремонт', '3');
INSERT INTO public."ConstractionType" VALUES ('7f5501ba-ae9b-45e2-839e-941c15f2b94f', 'Реконструкция', '2');
INSERT INTO public."ConstractionType" VALUES ('d3edb3a3-fe7f-4e08-a33b-1c9d6c5fc9c3', 'Строительство', '1');


--
-- Data for Name: ConstructionDates; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: DangerIndustrialClass; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."DangerIndustrialClass" VALUES ('4ffe5468-3230-4781-8ae3-31b55465e447', 'IV класс опасности - опасные производственные объекты низкой опасности', 'IV');
INSERT INTO public."DangerIndustrialClass" VALUES ('e608dc25-c9f6-413a-9ff2-97cad77c3974', 'III класс опасности - опасные производственные объекты средней опасности', 'III');
INSERT INTO public."DangerIndustrialClass" VALUES ('fb609ad2-b7c0-4d30-8055-d59e1e7598f9', 'II класс опасности - опасные производственные объекты высокой опасности', 'II');
INSERT INTO public."DangerIndustrialClass" VALUES ('1f8d1870-80bd-4a61-b067-cc39935048ea', 'I класс опасности - опасные производственные объекты чрезвычайно высокой опасности', 'I');
INSERT INTO public."DangerIndustrialClass" VALUES ('70a45e61-4de4-4b20-91c3-84da935814f8', 'Не относится к опасным производственным объектам', ' ');


--
-- Data for Name: DangerousAndComplex; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."DangerousAndComplex" VALUES ('14e6408c-3c30-41fa-95e4-a8c93cb48d4e', '11в) опасные производственные объекты, на которых ведутся горные работы (за исключением добычи общераспространенных полезных ископаемых и разработки россыпных месторождений полезных ископаемых, осуществляемых открытым способом без применения взрывных работ), работы по обогащению полезных ископаемых', '14');
INSERT INTO public."DangerousAndComplex" VALUES ('3a02fc1a-4d53-4ebe-a783-1d997fbc777a', '11б) опасные производственные объекты, на которых получаются, транспортируются, используются расплавы черных и цветных металлов, сплавы на основе этих расплавов с применением оборудования, рассчитанного на максимальное количество расплава 500 килограммов и более', '13');
INSERT INTO public."DangerousAndComplex" VALUES ('281e7bf2-5a80-469d-adb4-d18d57f40b64', '11а) опасные производственные объекты I и II классов опасности, на которых получаются, используются, перерабатываются, образуются, хранятся, транспортируются, уничтожаются опасные вещества', '12');
INSERT INTO public."DangerousAndComplex" VALUES ('9a867666-484d-4353-90d1-d2371da05b68', '10.2) подвесные канатные дороги', '11');
INSERT INTO public."DangerousAndComplex" VALUES ('e1fbfc58-93a4-48b3-9564-db09be3924de', '10.1) тепловые электростанции мощностью 150 мегаватт и выше', '10');
INSERT INTO public."DangerousAndComplex" VALUES ('b14886be-f8e0-49b4-a7ab-f8146f50ab44', '9) портовые гидротехнические сооружения, относящиеся к объектам инфраструктуры морского порта, за исключением объектов инфраструктуры морского порта, предназначенных для стоянок и обслуживания маломерных, спортивных парусных и прогулочных судов', '9');
INSERT INTO public."DangerousAndComplex" VALUES ('15eea901-664f-4c2a-8b92-f1195e2d2478', '8) объекты инфраструктуры внеуличного транспорта', '8');
INSERT INTO public."DangerousAndComplex" VALUES ('74f48cdf-1fdc-4f18-9cf8-f49792502aa7', '7) объекты капитального строительства инфраструктуры железнодорожного транспорта общего пользования, являющиеся особо опасными, технически сложными объектами в соответствии с законодательством Российской Федерации о железнодорожном транспорте', '7');
INSERT INTO public."DangerousAndComplex" VALUES ('25016cfa-1d9b-4e39-82f5-476af49ec81c', '6) объекты инфраструктуры воздушного транспорта, являющиеся особо опасными, технически сложными объектами в соответствии с воздушным законодательством Российской Федерации', '6');
INSERT INTO public."DangerousAndComplex" VALUES ('b07238ab-ff3c-4682-b133-5575a08a84fb', '5) объекты космической инфраструктуры', '5');
INSERT INTO public."DangerousAndComplex" VALUES ('a511e04d-0ed3-4659-8b31-1de76c579a4b', '4) линии электропередачи и иные объекты электросетевого хозяйства напряжением 330 киловольт и более', '4');
INSERT INTO public."DangerousAndComplex" VALUES ('932786d0-7c84-445f-8da1-87648855a26c', '3) сооружения связи, являющиеся особо опасными, технически сложными в соответствии с законодательством Российской Федерации в области связи', '3');
INSERT INTO public."DangerousAndComplex" VALUES ('98516412-8089-474a-8f81-b4ef9bcf0740', '2) гидротехнические сооружения первого и второго классов, устанавливаемые в соответствии с законодательством о безопасности гидротехнических сооружений', '2');
INSERT INTO public."DangerousAndComplex" VALUES ('ba490eed-eb85-48ed-88fd-5b1d5c6f9e43', '1) объекты использования атомной энергии в соответствии с законодательством Российской Федерации об использовании атомной энергии, за исключением объектов, содержащих:
а) только радиационные источники, в которых генерируется ионизирующее излучение, на объектах, радиационное воздействие от которых в случае аварии ограничивается помещениями, где осуществляется непосредственное обращение с источниками ионизирующего излучения;
б) радиационные источники, содержащие в своем составе только радионуклидные источники четвертой и пятой категорий радиационной опасности в соответствии с законодательством Российской Федерации об использовании атомной энергии ', '1');


--
-- Data for Name: Data; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Person; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Developer; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ProjectDocumentNotNecessarySectionContent; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Document; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: EfficiencyClass; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."EfficiencyClass" VALUES ('f833676c-8b71-44b2-8962-0b10280b149a', 'Класс энергетической эффективности G', 'G');
INSERT INTO public."EfficiencyClass" VALUES ('29c0c620-3943-434d-bdc1-40f30d32bb16', 'Класс энергетической эффективности F', 'F');
INSERT INTO public."EfficiencyClass" VALUES ('33c8990c-74c9-41d6-b5bd-a66ba9b12955', 'Класс энергетической эффективности E', 'E');
INSERT INTO public."EfficiencyClass" VALUES ('f031afe4-0d41-4ed7-bc52-1211f48ede72', 'Класс энергетической эффективности D', 'D');
INSERT INTO public."EfficiencyClass" VALUES ('f27f59e3-70a3-4e92-9c6a-42d6fb1e2243', 'Класс энергетической эффективности C', 'C');
INSERT INTO public."EfficiencyClass" VALUES ('13eceda3-d980-454f-b13d-3ced7f04204f', 'Класс энергетической эффективности B', 'B');
INSERT INTO public."EfficiencyClass" VALUES ('8f7b27e6-0c1a-46f7-b0a6-258f9634aced', 'Класс энергетической эффективности A', 'A');
INSERT INTO public."EfficiencyClass" VALUES ('aaaa6c0f-a92d-4f0c-9de1-ccca3f655834', 'Класс энергетической эффективности A+', 'A+');
INSERT INTO public."EfficiencyClass" VALUES ('42af8642-6c43-4abc-bf98-d6cf06baaebf', 'Класс энергетической эффективности A++', 'A++');
INSERT INTO public."EfficiencyClass" VALUES ('523cd156-c66f-489f-b7b8-df0a56dfd642', 'Не подлежит классификации по показателю «Класс энергетической эффективности»', 'Не классифицируется');


--
-- Data for Name: EnergyEfficiency; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ProjectDocParticipants; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ProjectDocumentSectionContent; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ProjectDocumentSubSection; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ProjectDocument; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: File; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: FireDangerCategory; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."FireDangerCategory" VALUES ('d4b281de-f819-41e1-8585-9ad1ac54d0d3', 'Категория пожарной и взрывопожарной опасности Д', 'Д');
INSERT INTO public."FireDangerCategory" VALUES ('ae887596-8511-4647-80d3-b555049a095c', 'Категория пожарной и взрывопожарной опасности Г', 'Г');
INSERT INTO public."FireDangerCategory" VALUES ('87f13cfd-f9a7-494f-9a7e-dd8b3ab2ae75', 'Категория пожарной и взрывопожарной опасности В', 'В');
INSERT INTO public."FireDangerCategory" VALUES ('8e9b5189-e5db-4f09-a352-72258d8a608d', 'Категория пожарной и взрывопожарной опасности Б', 'Б');
INSERT INTO public."FireDangerCategory" VALUES ('1709119a-a953-4bfd-9b45-51a6d9fff76c', 'Категория пожарной и взрывопожарной опасности А', 'А');


--
-- Data for Name: Functions; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: SectionOtherContent; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: OtherDocumentsSection; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ProjectDocumentSection; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: GasLinearProjectDocumentContent; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: GasNetworksFeatures; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Image; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: LandInfo; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: MonitoringPrograms; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Section5Content; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Section5; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: SectionEstimateContent; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: SectionEstimate; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: NonLinearProjectDocumentContent; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: NuclearPlantFeatures; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Placement; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Placement" VALUES ('1752961d-9d31-47d8-9728-e93f2a6c7c93', 'Водный объект', '2');
INSERT INTO public."Placement" VALUES ('9958ffd0-d612-4ebc-9cef-0c12e534587c', 'Объекты, расположенные на суше', '1');


--
-- Data for Name: ProjectDocumentationLinks; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Resources; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ResponsibilityLevel; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."ResponsibilityLevel" VALUES ('c16300a3-2445-4623-9a09-12f670fd4cf2', 'пониженный', 'пониженный');
INSERT INTO public."ResponsibilityLevel" VALUES ('0be7ed05-1610-4b5d-947d-1e616add1101', 'нормальный', 'нормальный');
INSERT INTO public."ResponsibilityLevel" VALUES ('8fb61f45-796c-4dcd-9c98-b33c853c3961', 'повышенный', 'повышенный');


--
-- Data for Name: SoftwareUsed; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: StagesInfo; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Unique; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Unique" VALUES ('55b1efc2-f84e-4275-b81b-92ed79af3ea1', '4) заглубление подземной части (полностью или частично) ниже планировочной отметки земли более чем на 15 метров', '4');
INSERT INTO public."Unique" VALUES ('48bf87ec-98ad-4397-b9d6-d55d377ccb66', '3) наличие консоли более чем 20 метров', '3');
INSERT INTO public."Unique" VALUES ('9673beed-da34-4a00-831a-21f32b3829fa', '2) пролеты более чем 100 метров', '2');
INSERT INTO public."Unique" VALUES ('9255af64-92b8-48d9-ad9e-3781463f48be', '1) высота более чем 100 метров, для ветроэнергетических установок - более чем 250 метров', '1');


--
-- Data for Name: IndustrialObject; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: LandCategory; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."LandCategory" VALUES ('1600a660-6a2b-4d83-abf2-acb4472923d4', 'Земли запаса', '7');
INSERT INTO public."LandCategory" VALUES ('44eb7154-4979-4c2c-b03a-692a8d1c2907', 'Земли водного фонда', '6');
INSERT INTO public."LandCategory" VALUES ('2478a7e6-52e6-4683-85be-10bfd494278a', 'Земли лесного фонда', '5');
INSERT INTO public."LandCategory" VALUES ('f539a1b6-0f0d-4a4b-b7c8-8a5175ed7dd2', 'Земли особо охраняемых территорий и объектов', '4');
INSERT INTO public."LandCategory" VALUES ('60c27c4f-70da-4860-b3ab-b24e59b4ab77', 'Земли промышленности, энергетики, транспорта, связи, радиовещания, телевидения, информатики, земли для обеспечения космической деятельности, земли обороны, безопасности и земли иного специального назначения', '3');
INSERT INTO public."LandCategory" VALUES ('3fb6f916-f713-44c8-b655-44beda74c42d', 'Земли населенных пунктов', '2');
INSERT INTO public."LandCategory" VALUES ('762e8fb4-0cef-425e-a28e-c08e4f0851bd', 'Земли сельскохозяйственного назначения', '1');


--
-- Data for Name: LandAreaInfo; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: LinearProjectDocumentContent; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Routes; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: LinearObject; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: NonIndustrialObject; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: LandCategoryMappings; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ModelFile; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ModelFormat; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."ModelFormat" VALUES ('7a695b23-e70b-4265-9147-8a11a6856ca0', 'LandXML', 'LandXML');
INSERT INTO public."ModelFormat" VALUES ('ae9f6372-a4f4-48c9-9cf3-d78d29d2008f', 'XML', 'XML');
INSERT INTO public."ModelFormat" VALUES ('19376bf4-5619-4082-adb1-1d01c11156a8', 'IFC', 'IFC');


--
-- Data for Name: Modification; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: OKEI; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."OKEI" VALUES ('cd9e954e-a3ad-42ae-8580-e637a25f3bf4', 'Морская миля (1852 м)', '047');
INSERT INTO public."OKEI" VALUES ('15dcf0ed-0836-40f6-98b9-1c5d8438bdca', 'Ярд (0,9144 м)', '043');
INSERT INTO public."OKEI" VALUES ('feef8a68-5bf6-4877-9143-18573299d4e3', 'Фут (0,3048 м)', '041');
INSERT INTO public."OKEI" VALUES ('fdada450-6c1f-4d68-9f8d-f47aeb3c8d60', 'Дюйм (25,4 мм)', '039');
INSERT INTO public."OKEI" VALUES ('000b83a9-103f-4243-9206-96e1cf018fd4', 'Мегаметр; миллион метров', '009');
INSERT INTO public."OKEI" VALUES ('d4c1b3d6-d693-46d5-a721-b1f5ad328274', 'Километр; тысяча метров', '008');
INSERT INTO public."OKEI" VALUES ('c21b12e6-366f-46d9-a973-884f96308ded', 'Метр', '006');
INSERT INTO public."OKEI" VALUES ('85cdea77-fbab-4b8c-9840-4f811cd6f22d', 'Дециметр', '005');
INSERT INTO public."OKEI" VALUES ('91f914bf-262d-4e49-8db1-35a80a046e76', 'Сантиметр', '004');
INSERT INTO public."OKEI" VALUES ('aa6a2426-6198-4776-8ba9-b7f26c750b68', 'Миллиметр', '003');
INSERT INTO public."OKEI" VALUES ('e0669840-8f84-4ebe-acf5-a2e54c771af6', 'Квадратный ярд (0,8361274 м^2)', '075');
INSERT INTO public."OKEI" VALUES ('33cb0d05-47ab-4ee7-9ada-55a6c3b5225c', 'Квадратный фут (0,092903 м^2)', '073');
INSERT INTO public."OKEI" VALUES ('53a4eb95-6992-4249-bb41-8243985f9785', 'Квадратный дюйм (645,16 мм^2)', '071');
INSERT INTO public."OKEI" VALUES ('9b8cc8cf-8d89-45f5-9b2a-c818e9c59dfc', 'Квадратный километр', '061');
INSERT INTO public."OKEI" VALUES ('a6946102-7320-4bf2-b082-ea0e923a2dbb', 'Гектар', '059');
INSERT INTO public."OKEI" VALUES ('b89c668a-976d-4950-8486-d2918cb186ad', 'Тысяча квадратных метров', '058');
INSERT INTO public."OKEI" VALUES ('513115cc-d602-4092-9bc4-b747c2db2046', 'Квадратный метр', '055');
INSERT INTO public."OKEI" VALUES ('2cfa27a7-71bd-4e9d-aa4a-5b4078069a17', 'Квадратный дециметр', '053');
INSERT INTO public."OKEI" VALUES ('85bfa6e9-d64e-45df-ac9f-28a7689ec0d6', 'Квадратный сантиметр', '051');
INSERT INTO public."OKEI" VALUES ('c8412937-7206-47ef-94d4-3f5ed6dfb02a', 'Квадратный миллиметр', '050');
INSERT INTO public."OKEI" VALUES ('78a51ad6-0e8e-48c5-b313-e8f16a824ada', 'Кубический фут (0,02831685 м^3)', '132');
INSERT INTO public."OKEI" VALUES ('1511664a-8aa2-4436-8639-2f5df7e08f23', 'Кубический дюйм (16387,1 мм^3)', '131');
INSERT INTO public."OKEI" VALUES ('2ba07090-9e03-47ba-a919-4e10b034755d', 'Мегалитр', '126');
INSERT INTO public."OKEI" VALUES ('07f4e9f2-4000-48e3-9ce7-b9dae1bb1aef', 'Гектолитр', '122');
INSERT INTO public."OKEI" VALUES ('740fa230-e387-4192-8ea2-461b5d29cf8b', 'Децилитр', '118');
INSERT INTO public."OKEI" VALUES ('ba962e94-842c-49a5-a77d-09a59533bcc3', 'Кубический метр', '113');
INSERT INTO public."OKEI" VALUES ('251bbcc5-4e98-40bf-82d8-6dff83065e73', 'Литр; кубический дециметр', '112');
INSERT INTO public."OKEI" VALUES ('8be6109b-06c1-43d1-85b9-e5cb7e859dac', 'Кубический сантиметр; миллилитр', '111');
INSERT INTO public."OKEI" VALUES ('8ea5a1b0-957e-414f-8598-0cfdfad7557d', 'Кубический миллиметр', '110');
INSERT INTO public."OKEI" VALUES ('f7bbc077-1523-4d48-ad97-f0da04026ecc', 'Ар (100 м^2)', '109');
INSERT INTO public."OKEI" VALUES ('49c618f7-8114-476b-b626-d29786d6513b', 'Сантиграмм', '173');
INSERT INTO public."OKEI" VALUES ('8f08fe73-9499-41b7-b1e1-f9025679a577', 'Килотонна', '170');
INSERT INTO public."OKEI" VALUES ('5a4ff973-6ac2-4094-b2a7-96ba936c98c7', 'Тонна; метрическая тонна (1000 кг)', '168');
INSERT INTO public."OKEI" VALUES ('75ee8bc3-5d93-4c89-8ef4-60fb595c38e5', 'Килограмм', '166');
INSERT INTO public."OKEI" VALUES ('020bfa98-b562-46d6-ad41-5f62e3aeeb7d', 'Грамм', '163');
INSERT INTO public."OKEI" VALUES ('672dff15-5eb8-4567-8ef7-686a4cc27083', 'Метрический карат', '162');
INSERT INTO public."OKEI" VALUES ('c9a5bd22-869b-4cb2-937f-68605978ee71', 'Миллиграмм', '161');
INSERT INTO public."OKEI" VALUES ('46b7e51b-ba49-4b38-93e3-ad37ebddbfa5', 'Гектограмм', '160');
INSERT INTO public."OKEI" VALUES ('de4d696c-5230-4b23-b5b0-bbeeaf04130f', 'Миллион кубических метров', '159');
INSERT INTO public."OKEI" VALUES ('c40921f4-553d-4e94-b86a-d308182155a0', 'Кубический ярд (0,764555 м^3)', '133');
INSERT INTO public."OKEI" VALUES ('1d92d1b8-ee41-4e97-9acc-c5f08646d902', 'Мегавольт-ампер (тысяча киловольт-ампер)', '228');
INSERT INTO public."OKEI" VALUES ('478bcdad-8422-4ddc-bd07-ae96c4095e56', 'Киловольт-ампер', '227');
INSERT INTO public."OKEI" VALUES ('062535d5-743f-4079-8448-f1903242f8fa', 'Киловольт', '223');
INSERT INTO public."OKEI" VALUES ('538fd49e-feca-4d05-9607-7b6b8ca97634', 'Вольт', '222');
INSERT INTO public."OKEI" VALUES ('25eaedda-5930-462d-b6dd-eae40ebfe122', 'Мегаватт; тысяча киловатт', '215');
INSERT INTO public."OKEI" VALUES ('bdc62716-661d-41db-9424-b2dcc48c510b', 'Киловатт', '214');
INSERT INTO public."OKEI" VALUES ('88acbcf8-93d7-4204-9375-0f4ffeb7b087', 'Ватт', '212');
INSERT INTO public."OKEI" VALUES ('654c836f-acbf-4990-8b46-e22ebe85cea1', 'Центнер (метрический) (100 кг); гектокилограмм; квинтал (метрический); децитонна', '206');
INSERT INTO public."OKEI" VALUES ('db5253c3-758d-4c8f-b36c-d4d1ccc973d0', 'Грузоподъемность в метрических тоннах', '185');
INSERT INTO public."OKEI" VALUES ('146a340b-4af9-4bc0-901b-9875a00aa04f', 'Брутто-регистровая тонна (2,8316 м^3)', '181');
INSERT INTO public."OKEI" VALUES ('004c889f-b550-4764-aea7-ea432bb68dae', 'Джоуль', '271');
INSERT INTO public."OKEI" VALUES ('c90a4105-f5d4-4f32-b690-4990be99ffd7', 'Кулон', '270');
INSERT INTO public."OKEI" VALUES ('1f403539-764a-460c-9bcf-7905a8a504cc', 'Тысяча ампер-часов', '264');
INSERT INTO public."OKEI" VALUES ('45692c8f-0df0-4bef-a7cb-f9a80927daf3', 'Ампер-час (3,6 кКл)', '263');
INSERT INTO public."OKEI" VALUES ('97df8979-f9ad-459f-bbda-237dda25bc99', 'Ампер', '260');
INSERT INTO public."OKEI" VALUES ('3d364aea-11af-48e7-bb30-a3c910efb594', 'Гигаватт-час (миллион киловатт-часов)', '247');
INSERT INTO public."OKEI" VALUES ('3d228a47-8e3a-47f3-a6b9-887916dfb306', 'Мегаватт-час; 1000 киловатт-часов', '246');
INSERT INTO public."OKEI" VALUES ('d51b7898-69d2-4c2b-aa31-496b83af9baa', 'Киловатт-час', '245');
INSERT INTO public."OKEI" VALUES ('ef610f40-93ca-4038-ad20-15fe29bef4dd', 'Ватт-час', '243');
INSERT INTO public."OKEI" VALUES ('fc9e094c-25a6-4ef7-8834-7962ebbe2cfe', 'Киловар', '230');
INSERT INTO public."OKEI" VALUES ('5448d472-4cc4-4847-8ac2-07395d51179f', 'Герц', '290');
INSERT INTO public."OKEI" VALUES ('b5b23254-b1e7-4f53-ac75-4d9fa1867aa5', 'Ньютон', '289');
INSERT INTO public."OKEI" VALUES ('31385ccd-16ee-488b-a8e0-d2bc72d7ff5b', 'Кельвин', '288');
INSERT INTO public."OKEI" VALUES ('3a98e13e-eaa9-4016-9e81-7d3228222cd8', 'Люмен', '284');
INSERT INTO public."OKEI" VALUES ('90799468-624f-4ee2-9e6d-096327f7922c', 'Люкс', '283');
INSERT INTO public."OKEI" VALUES ('e2adee3d-c010-4621-944b-c5d95bc991a5', 'Кандела', '282');
INSERT INTO public."OKEI" VALUES ('a8abdbf4-e7b8-42fe-894f-27d4d3e8a194', 'Градус Фаренгейта', '281');
INSERT INTO public."OKEI" VALUES ('a3d322fb-b857-4b62-9803-6119b705e927', 'Градус Цельсия', '280');
INSERT INTO public."OKEI" VALUES ('ae77afcc-573d-494d-a3bc-cb8752f82caa', 'Ом', '274');
INSERT INTO public."OKEI" VALUES ('9235edfa-fda8-4449-b050-2009c467db61', 'Килоджоуль', '273');
INSERT INTO public."OKEI" VALUES ('08a18a85-0331-43ce-9192-9c886623b44c', 'Милликюри', '304');
INSERT INTO public."OKEI" VALUES ('cb7bb5a3-be4d-4111-a7d7-f2a99985fb04', 'Гигабеккерель', '302');
INSERT INTO public."OKEI" VALUES ('87a168c3-c275-484e-9595-7b63b2089cc4', 'Техническая атмосфера (98066,5 Па)', '301');
INSERT INTO public."OKEI" VALUES ('029bcc21-8407-46f0-96a8-bdbd40b7f611', 'Физическая атмосфера (101325 Па)', '300');
INSERT INTO public."OKEI" VALUES ('3b53eb8e-6c04-4c3f-b10b-05dfa4a41a8b', 'Мегапаскаль', '298');
INSERT INTO public."OKEI" VALUES ('14f7415c-9d89-4915-95c0-3242332d110d', 'Килопаскаль', '297');
INSERT INTO public."OKEI" VALUES ('1e8d6fb8-fdbc-469b-a34f-94b6d0c64229', 'Сименс', '296');
INSERT INTO public."OKEI" VALUES ('88df9114-dfe2-438f-afd5-7e525af23bb8', 'Паскаль', '294');
INSERT INTO public."OKEI" VALUES ('30c4fb30-c251-4e6f-8ccd-39dbd689874a', 'Мегагерц', '292');
INSERT INTO public."OKEI" VALUES ('cef63ffe-3397-419c-8083-61b22c46830c', 'Килогерц', '291');
INSERT INTO public."OKEI" VALUES ('40e9b351-d64b-40ca-87dc-669ba522f09e', 'Вебер', '324');
INSERT INTO public."OKEI" VALUES ('96135803-5d64-4d63-a035-7e4aa3626a43', 'Беккерель', '323');
INSERT INTO public."OKEI" VALUES ('bdfec70f-ea33-40bc-bc0c-38c4e2962726', 'Килограмм на кубический метр', '316');
INSERT INTO public."OKEI" VALUES ('184218ff-cfec-4e38-937d-7aaf801d4289', 'Фарад', '314');
INSERT INTO public."OKEI" VALUES ('5b7835e6-813d-49bd-bbb8-a4f2490e01d9', 'Килобар', '312');
INSERT INTO public."OKEI" VALUES ('d9739d74-70cf-44d5-b50e-44e461292bf7', 'Гектобар', '310');
INSERT INTO public."OKEI" VALUES ('230a139a-834f-43df-93c7-f781c2e96dbe', 'Бар', '309');
INSERT INTO public."OKEI" VALUES ('6f494813-1f6c-4230-b96e-f9f9d0bdfbab', 'Миллибар', '308');
INSERT INTO public."OKEI" VALUES ('70b11872-263e-43c5-b6c9-fde5adec7541', 'Грамм делящихся изотопов', '306');
INSERT INTO public."OKEI" VALUES ('bf860397-9fee-46f5-b1e8-3cf6a9b73056', 'Кюри', '305');
INSERT INTO public."OKEI" VALUES ('056535f8-4099-4378-b7f1-0f60d04f6095', 'Час', '356');
INSERT INTO public."OKEI" VALUES ('04618bf4-487d-48d2-b4cc-4db49d347e0d', 'Минута', '355');
INSERT INTO public."OKEI" VALUES ('05beb6a4-cf5d-46c2-ba5b-d53432f379de', 'Секунда', '354');
INSERT INTO public."OKEI" VALUES ('da97b1c4-9f62-4b8c-9b8b-6876449bea87', 'Кулон на килограмм', '349');
INSERT INTO public."OKEI" VALUES ('e6ef0859-fd05-4acf-9228-f24a5d98d6d1', 'Метр на секунду в квадрате', '335');
INSERT INTO public."OKEI" VALUES ('bffbd415-2aa7-41dc-8f1b-8b5887e0b3ee', 'Километр в час', '333');
INSERT INTO public."OKEI" VALUES ('7c5ad165-a660-4e4f-8f51-415599051eab', 'Оборот в минуту', '331');
INSERT INTO public."OKEI" VALUES ('78b0fd56-8ab2-4b74-b6df-f030d70eb3cd', 'Оборот в секунду', '330');
INSERT INTO public."OKEI" VALUES ('83413a16-4106-433b-9f64-4de0e0d49bbd', 'Метр в секунду', '328');
INSERT INTO public."OKEI" VALUES ('3194be40-74ad-4655-a2f2-aa48517ceb44', 'Узел (миля/ч)', '327');
INSERT INTO public."OKEI" VALUES ('3f209743-3fd8-4ff4-bb13-f99f4b745943', 'Грей', '276');
INSERT INTO public."OKEI" VALUES ('1e1b09be-e0d8-474b-b487-9af50580e95f', 'Тонна пара в час', '533');
INSERT INTO public."OKEI" VALUES ('c2874f6f-e402-4d51-a5b0-8c3af2371577', 'Килограмм в секунду', '499');
INSERT INTO public."OKEI" VALUES ('4696d36b-bae2-4473-a2e6-b44866ba92a8', 'Десятилетие', '368');
INSERT INTO public."OKEI" VALUES ('498024f4-e3e3-4f84-9243-90baa90d0c8c', 'Год', '366');
INSERT INTO public."OKEI" VALUES ('07da3007-e470-4c96-a970-450cdd7791f3', 'Полугодие', '365');
INSERT INTO public."OKEI" VALUES ('37401294-d574-4f53-a351-7cb7827189f8', 'Квартал', '364');
INSERT INTO public."OKEI" VALUES ('0777c26e-0dd3-46a3-903d-df0690e1917c', 'Месяц', '362');
INSERT INTO public."OKEI" VALUES ('4af97390-75d9-45eb-be79-ef6825895f9f', 'Декада', '361');
INSERT INTO public."OKEI" VALUES ('e1a345b7-4ced-42b7-855d-a0e0161f8285', 'Неделя', '360');
INSERT INTO public."OKEI" VALUES ('1f354b94-da06-481f-9fae-0593e990c43a', 'Сутки', '359');
INSERT INTO public."OKEI" VALUES ('12e64186-f90a-4bec-8a9d-88ca1f22bdf3', 'Сто ящиков', '683');
INSERT INTO public."OKEI" VALUES ('2d30570f-74e9-4559-ba97-f23a2bbddf2f', 'Изделие', '657');
INSERT INTO public."OKEI" VALUES ('31a8c703-5bff-4faf-aedc-bda699e362c5', 'Дюжина (12 шт.)', '641');
INSERT INTO public."OKEI" VALUES ('e24d97db-41e8-4216-ad0a-f8bf7a930add', 'Тысяча стандартных условных кирпичей', '630');
INSERT INTO public."OKEI" VALUES ('ac1e8aed-2df3-42f2-9f14-858274fd9aab', 'Сто листов', '626');
INSERT INTO public."OKEI" VALUES ('70119596-1f95-4d29-9073-81a17fe10856', 'Лист', '625');
INSERT INTO public."OKEI" VALUES ('54da0976-fbb7-40b7-b09e-f1d7659a13a6', 'Бобина', '616');
INSERT INTO public."OKEI" VALUES ('59a24f4c-d938-4b5b-b8a7-2feff5288ae3', 'Тысяча кубических метров в сутки', '599');
INSERT INTO public."OKEI" VALUES ('cdca13ab-3676-4ce1-862a-51ec7ea6ef55', 'Кубический метр в час', '598');
INSERT INTO public."OKEI" VALUES ('71dfb7a7-08ba-4c4e-a7f9-26cee85adb17', 'Кубический метр в секунду', '596');
INSERT INTO public."OKEI" VALUES ('c3a25bab-de54-4190-a8a5-fa11cdecb9bf', 'Часть', '735');
INSERT INTO public."OKEI" VALUES ('7c99928c-dbd7-4ddc-8ae2-f4056a3535d9', 'Посылка', '734');
INSERT INTO public."OKEI" VALUES ('ab5a88d0-3ae5-43d7-bd6c-9ac82fda587a', 'Дюжина пар', '733');
INSERT INTO public."OKEI" VALUES ('9c6ff0cb-2e84-4b57-9b19-f84379640cfa', 'Десять пар', '732');
INSERT INTO public."OKEI" VALUES ('24d2920d-34a0-4ecc-9bae-b1f0291c4f5c', 'Два десятка', '730');
INSERT INTO public."OKEI" VALUES ('cf79ef28-86dc-4351-a86e-d69e006525e9', 'Пара (2 шт.)', '715');
INSERT INTO public."OKEI" VALUES ('36e4690e-6c5a-4841-808d-c34d24a87b64', 'Набор', '704');
INSERT INTO public."OKEI" VALUES ('4b25335a-5486-43a3-94bc-2388eafa4521', 'Тысяча штук', '798');
INSERT INTO public."OKEI" VALUES ('f51bc618-dcec-4f8b-9595-f8c56926e94e', 'Сто штук', '797');
INSERT INTO public."OKEI" VALUES ('cfc617f9-495b-41c0-bf7c-0664b7d32f33', 'Штука', '796');
INSERT INTO public."OKEI" VALUES ('5eaeb84c-12e8-4537-8c94-623a84e0d8b7', 'Сто упаковок', '781');
INSERT INTO public."OKEI" VALUES ('0a5944c5-b673-455a-afd5-deff1fecd33b', 'Дюжина упаковок', '780');
INSERT INTO public."OKEI" VALUES ('b17e004c-49cc-41a2-bd57-568d26b9b7d6', 'Упаковка', '778');
INSERT INTO public."OKEI" VALUES ('e2ae6e9e-ef33-4b3c-908c-52b91f93262c', 'Элемент', '745');
INSERT INTO public."OKEI" VALUES ('6952eb5e-e83d-45a1-8307-a7740eb0e814', 'Дюжина штук', '740');
INSERT INTO public."OKEI" VALUES ('6fc37eac-bcc9-4327-867a-5ee401c80b45', 'Дюжина рулонов', '737');
INSERT INTO public."OKEI" VALUES ('a0e61971-d0ea-4e5d-99f3-008dac0c1706', 'Рулон', '736');
INSERT INTO public."OKEI" VALUES ('a5eee4a4-21d0-4c08-b1ed-fa72073a01f6', 'Килограмм 90%-го сухого вещества', '845');
INSERT INTO public."OKEI" VALUES ('ea62cc11-7635-471a-91cf-23048f9780b1', 'Килограмм пероксида водорода', '841');
INSERT INTO public."OKEI" VALUES ('d53dd7a9-5e76-4b1d-a888-70f04fcefdf3', 'Гектолитр чистого (100%) спирта', '833');
INSERT INTO public."OKEI" VALUES ('406965dc-eb6e-4983-9322-19298fda9779', 'Литр чистого (100%) спирта', '831');
INSERT INTO public."OKEI" VALUES ('c40ef9fe-8182-4e32-af8e-4761bf8ac9d0', 'Крепость спирта по объему', '821');
INSERT INTO public."OKEI" VALUES ('70e98eb0-9070-4c23-ae30-7ab73a2a3b0b', 'Крепость спирта по массе', '820');
INSERT INTO public."OKEI" VALUES ('9e2465fb-f516-4519-babb-24e1a89bd670', 'Квинтильон штук (Европа)', '802');
INSERT INTO public."OKEI" VALUES ('ee0e3fd6-0885-4535-bcce-450bab8a1b8b', 'Биллион штук (Европа); триллион штук', '801');
INSERT INTO public."OKEI" VALUES ('20338b9e-85b3-4142-90f4-6aedad21e925', 'Миллиард штук', '800');
INSERT INTO public."OKEI" VALUES ('72c080ba-093e-42df-b42f-965ddedbaadb', 'Миллион штук', '799');
INSERT INTO public."OKEI" VALUES ('d279588e-579a-4458-b55d-783b87340925', 'Условный метр', '020');
INSERT INTO public."OKEI" VALUES ('6b4c27b8-0daa-4d9b-95df-1cb38100ca93', 'Тысяча погонных метров', '019');
INSERT INTO public."OKEI" VALUES ('bc2a1a43-3be0-4485-ad5c-6eca2b61d3b6', 'Погонный метр', '018');
INSERT INTO public."OKEI" VALUES ('af3c585c-b47d-43fa-b36e-871bf0edb209', 'Килограмм урана', '867');
INSERT INTO public."OKEI" VALUES ('a7803831-1a3a-486d-a868-90f6e455999f', 'Килограмм пятиокиси фосфора', '865');
INSERT INTO public."OKEI" VALUES ('94c0ebb2-7d81-4225-8090-1860a5c0e602', 'Килограмм гидроксида натрия', '863');
INSERT INTO public."OKEI" VALUES ('8e93f761-28bd-4b7c-b315-9416a73eff1f', 'Килограмм азота', '861');
INSERT INTO public."OKEI" VALUES ('a847533a-9bd7-4517-b7c1-08c6bc5b665d', 'Килограмм гидроксида калия', '859');
INSERT INTO public."OKEI" VALUES ('5f2bee91-e972-4f13-a8a1-9dd3b7bd2934', 'Килограмм оксида калия', '852');
INSERT INTO public."OKEI" VALUES ('485ae176-546a-4393-9469-a6db8d8667b9', 'Тонна 90%-го сухого вещества', '847');
INSERT INTO public."OKEI" VALUES ('551b8e42-c17a-4fe3-8dac-5a54f95aa23a', 'Квадратный метр общей площади', '081');
INSERT INTO public."OKEI" VALUES ('94583dc9-2128-4b53-a9bb-5d454ed34f3f', 'Миллион условных квадратных метров', '064');
INSERT INTO public."OKEI" VALUES ('d59b5672-87ae-4500-b074-fd3118bbdb7a', 'Тысяча условных квадратных метров', '063');
INSERT INTO public."OKEI" VALUES ('76256aec-41ec-4fea-8edc-8dfffb698d58', 'Условный квадратный метр', '062');
INSERT INTO public."OKEI" VALUES ('357d52b1-146a-4879-9854-515f765c3386', 'Тысяча гектаров', '060');
INSERT INTO public."OKEI" VALUES ('e58cfa68-e1fd-4ab1-8716-15528d92b1df', 'Миллион квадратных метров', '057');
INSERT INTO public."OKEI" VALUES ('847a64a0-3782-42e5-90ad-e3e8f67afc78', 'Миллион квадратных дециметров', '056');
INSERT INTO public."OKEI" VALUES ('31b1e81d-9552-452f-91fc-2859757d0444', 'Тысяча квадратных дециметров', '054');
INSERT INTO public."OKEI" VALUES ('51d32c59-524c-4e39-8a48-20980dc63494', 'Километр условных труб', '049');
INSERT INTO public."OKEI" VALUES ('ab2eae0c-1f7a-48de-8a64-d5e53bc374c7', 'Тысяча условных метров', '048');
INSERT INTO public."OKEI" VALUES ('92f734bd-49bf-486e-8f53-95fc8ea63937', 'Тысяча квадратных метров учебно-лабораторных зданий', '088');
INSERT INTO public."OKEI" VALUES ('f086612c-7697-4189-8fe7-96ce0005f968', 'Квадратный метр учебно-лабораторных зданий', '087');
INSERT INTO public."OKEI" VALUES ('597718d0-ed12-4d9f-81ab-cee972d76481', 'Миллион квадратных метров жилой площади', '086');
INSERT INTO public."OKEI" VALUES ('76b30bb7-da67-4665-81a6-97f219153fc2', 'Тысяча квадратных метров жилой площади', '085');
INSERT INTO public."OKEI" VALUES ('5a7315c7-ddf1-4113-a26a-4f2900dd40e4', 'Квадратный метр жилой площади', '084');
INSERT INTO public."OKEI" VALUES ('d804448d-83e1-49ef-86d8-0d4a7fc6f379', 'Миллион квадратных метров общей площади', '083');
INSERT INTO public."OKEI" VALUES ('e522fbe7-f545-4c29-8352-07e7f63811f1', 'Тысяча квадратных метров общей площади', '082');
INSERT INTO public."OKEI" VALUES ('3241c3bc-f3f1-4d5d-882a-7b6768bf5474', 'Миллион кубических метров переработки газа', '125');
INSERT INTO public."OKEI" VALUES ('a1727b84-a0ec-4000-bfc4-0b1ba8bf62a0', 'Тысяча условных кубических метров', '124');
INSERT INTO public."OKEI" VALUES ('ffa94a59-602a-413c-9c0b-7a19e55bff3e', 'Условный кубический метр', '123');
INSERT INTO public."OKEI" VALUES ('dceb4e56-549a-4ee3-96f0-1dc0cfebe2e1', 'Плотный кубический метр', '121');
INSERT INTO public."OKEI" VALUES ('b1e5209e-5952-46b5-bc14-8c5596356288', 'Миллион декалитров', '120');
INSERT INTO public."OKEI" VALUES ('3b135bd8-cd5a-43d9-bad8-7f43f9d0e40b', 'Тысяча декалитров', '119');
INSERT INTO public."OKEI" VALUES ('b4910e1f-d35c-4311-8630-f49d4e6df504', 'Декалитр', '116');
INSERT INTO public."OKEI" VALUES ('919b750b-a547-4506-ae06-91007a5fc04a', 'Миллиард кубических метров', '115');
INSERT INTO public."OKEI" VALUES ('5ae56810-faf7-4b26-b6cf-c6382328f9a4', 'Тысяча кубических метров', '114');
INSERT INTO public."OKEI" VALUES ('078c01f5-e5c8-450c-8853-39494ec958fd', 'Миллион квадратных метров в двухмиллиметровом исчислении', '089');
INSERT INTO public."OKEI" VALUES ('ffadea8c-3536-48cf-8254-4f06e81f7448', 'Тысяча тонн условного топлива', '175');
INSERT INTO public."OKEI" VALUES ('5f8bd0f0-a3af-4c99-9932-75cc4b20d4db', 'Тонна условного топлива', '172');
INSERT INTO public."OKEI" VALUES ('cfd1e32e-07f6-4a58-9cd8-0d5fbcfe5a66', 'Миллион тонн', '171');
INSERT INTO public."OKEI" VALUES ('9d6628a1-35af-4ff3-92e7-93e1cb04c6bd', 'Тысяча тонн', '169');
INSERT INTO public."OKEI" VALUES ('228c3459-4167-4613-9a8a-4e7ae81667f2', 'Миллион каратов метрических', '167');
INSERT INTO public."OKEI" VALUES ('ac2e4b69-4ce6-42c8-b6e8-d2625838dbaf', 'Тысяча каратов метрических', '165');
INSERT INTO public."OKEI" VALUES ('4ef2b517-cac7-40dd-a6e0-c291e0b763e7', 'Тысяча литров; 1000 литров', '130');
INSERT INTO public."OKEI" VALUES ('dc4c9172-a257-4a35-a258-706b24d43706', 'Миллион полулитров', '129');
INSERT INTO public."OKEI" VALUES ('ae2b21ac-1684-46e2-aaf0-5b294b841cb3', 'Тысяча полулитров', '128');
INSERT INTO public."OKEI" VALUES ('72acdfce-b3e0-4974-b4be-1c774963331a', 'Тысяча плотных кубических метров', '127');
INSERT INTO public."OKEI" VALUES ('d4cf7be0-490b-4b85-a513-1a3ffdd040ac', 'Тысяча гигакалорий', '234');
INSERT INTO public."OKEI" VALUES ('89663a24-3d75-40c7-b173-481295db1a7c', 'Гигакалория', '233');
INSERT INTO public."OKEI" VALUES ('1145d8d0-9172-4e1a-a598-5d1e7367d83f', 'Килокалория', '232');
INSERT INTO public."OKEI" VALUES ('b16dee64-5c48-40a5-aa4f-632b08a27bd0', 'Метр в час', '231');
INSERT INTO public."OKEI" VALUES ('1fc8bba7-a1ee-416f-8736-461ef1201771', 'Вольт-ампер', '226');
INSERT INTO public."OKEI" VALUES ('c8df6fa2-2cfa-4450-939f-e62f70956e23', 'Тысяча центнеров', '207');
INSERT INTO public."OKEI" VALUES ('dbd05c18-44bd-4772-ac48-a2dc33fed6fa', 'Условная тонна', '179');
INSERT INTO public."OKEI" VALUES ('637aced8-95c0-46b4-9dc7-eff85dffff4a', 'Тысяча тонн переработки', '178');
INSERT INTO public."OKEI" VALUES ('6628a95e-d81b-43e2-8409-f81a89b211a9', 'Тысяча тонн единовременного хранения', '177');
INSERT INTO public."OKEI" VALUES ('cd3773f2-2549-4f73-a4f2-c026737fc4b9', 'Миллион тонн условного топлива', '176');
INSERT INTO public."OKEI" VALUES ('1f291309-762a-4e28-887c-f8bada9801c6', 'Тысяча киловольт-ампер реактивных', '250');
INSERT INTO public."OKEI" VALUES ('358300ff-8118-4726-8659-1235af9bb6af', 'Миллиард киловатт-часов', '249');
INSERT INTO public."OKEI" VALUES ('7460eeaa-fc53-4fbf-bacd-b3a613a3970f', 'Киловольт-ампер реактивный', '248');
INSERT INTO public."OKEI" VALUES ('148e4180-9e22-492d-b653-ba71b5d70882', 'Миллион киловольт-ампер', '242');
INSERT INTO public."OKEI" VALUES ('e91f11d8-08f2-426b-9141-253c0334bfd7', 'Миллион ампер-часов', '241');
INSERT INTO public."OKEI" VALUES ('9bd57b64-5422-49a4-94fc-30017cbf5e49', 'Тысяча гигакалорий в час', '239');
INSERT INTO public."OKEI" VALUES ('63a9d01c-c82e-4931-b4d3-feab56889373', 'Гигакалория в час', '238');
INSERT INTO public."OKEI" VALUES ('d3a24ba9-bb50-4891-92b4-5a17fd5c7253', 'Килокалория в час', '237');
INSERT INTO public."OKEI" VALUES ('fef7cbc2-914d-4359-959f-6398b4ef8c82', 'Калория в час', '236');
INSERT INTO public."OKEI" VALUES ('11eec2d3-a6be-4e2e-a705-ff2cbdc3db66', 'Миллион гигакалорий', '235');
INSERT INTO public."OKEI" VALUES ('8bfc1b1b-d57a-49bb-8747-ff7c8cfc2108', 'Мегабайт', '257');
INSERT INTO public."OKEI" VALUES ('63f1e926-927e-4bfc-ae4c-b92759f91119', 'Килобайт', '256');
INSERT INTO public."OKEI" VALUES ('2c16d5d6-eced-414c-bfc3-27025761dd0f', 'Байт', '255');
INSERT INTO public."OKEI" VALUES ('64f75554-981a-4b25-afbe-b1b558bf5d54', 'Бит', '254');
INSERT INTO public."OKEI" VALUES ('8e1a1e22-479e-469b-bb5f-485ee1aa80dd', 'Миллион лошадиных сил', '253');
INSERT INTO public."OKEI" VALUES ('5a51fc58-bc90-4692-99a4-ab935cd8f6b4', 'Тысяча лошадиных сил', '252');
INSERT INTO public."OKEI" VALUES ('7dba7fde-b103-4c9d-ab75-e5894719a4ad', 'Лошадиная сила', '251');
INSERT INTO public."OKEI" VALUES ('29f4f608-d3f5-443a-a038-276a60578db6', 'Рубль', '383');
INSERT INTO public."OKEI" VALUES ('08e82f3c-2130-404b-8a8c-7e4637305606', 'Миллисекунда', '353');
INSERT INTO public."OKEI" VALUES ('d9c9451f-560d-4695-a7bd-e060317d5cca', 'Микросекунда', '352');
INSERT INTO public."OKEI" VALUES ('719b6cfe-9b87-4088-8c56-ccee534b5bb5', 'Сантиметр водяного столба', '339');
INSERT INTO public."OKEI" VALUES ('0b2c8981-f896-4430-8936-8ccc0eed542a', 'Миллиметр ртутного столба', '338');
INSERT INTO public."OKEI" VALUES ('7006c9d8-9bd0-470a-9c39-ceddd7800936', 'Миллиметр водяного столба', '337');
INSERT INTO public."OKEI" VALUES ('abe3c51a-7ebd-4377-9f57-118ecd8edbd3', 'Килограмм на квадратный сантиметр', '317');
INSERT INTO public."OKEI" VALUES ('3c917e79-ef91-43ee-a2da-29a2de3e5c55', 'Тесла', '313');
INSERT INTO public."OKEI" VALUES ('9cea22c8-ac72-4b64-bc73-4d38746b58e0', 'Генри', '287');
INSERT INTO public."OKEI" VALUES ('e30ec438-4221-41d8-b11a-8d8dd721141f', 'Бод', '258');
INSERT INTO public."OKEI" VALUES ('4e7ad4f0-a2fd-49c3-b483-fa889415e55b', 'Пассажиропоток', '427');
INSERT INTO public."OKEI" VALUES ('66137740-becf-44ab-8f82-d67357a4f200', 'Миллион пассажиро-километров', '424');
INSERT INTO public."OKEI" VALUES ('5408eb9f-716b-4cb6-93e5-989846f7bf4b', 'Тысяча пассажиро-километров', '423');
INSERT INTO public."OKEI" VALUES ('a4599ebc-7df2-4594-b1b1-9bf062b8ac63', 'Пассажирское место (пассажирских мест)', '421');
INSERT INTO public."OKEI" VALUES ('22c42922-aa14-4d3c-9abc-1e1001bb485e', 'Пассажиро-километр', '414');
INSERT INTO public."OKEI" VALUES ('51743903-fa5a-42f5-b272-cd08b3a22d20', 'Квадрильон рублей', '388');
INSERT INTO public."OKEI" VALUES ('4da32cf3-6df3-4c38-bf7a-8d3b2399281f', 'Триллион рублей', '387');
INSERT INTO public."OKEI" VALUES ('1c7ae2d1-b12e-4b80-b646-d36cb2b4cc7f', 'Миллиард рублей', '386');
INSERT INTO public."OKEI" VALUES ('31f65baf-6659-4d52-84c3-41d1e1c9c46a', 'Миллион рублей', '385');
INSERT INTO public."OKEI" VALUES ('88cf132e-faa8-4c00-85fb-79ec8554d2bd', 'Тысяча рублей', '384');
INSERT INTO public."OKEI" VALUES ('20ac6ce8-6c37-447e-b494-9cc84af7a362', 'Дедвейт-тонна', '515');
INSERT INTO public."OKEI" VALUES ('398c265e-3b28-4690-8c3b-39d5a3b66b53', 'Тонна тяги', '514');
INSERT INTO public."OKEI" VALUES ('ea459927-d724-40d3-9e08-ae992719d76b', 'Автотонна', '513');
INSERT INTO public."OKEI" VALUES ('45700686-5780-42d7-b771-67b450cf55ac', 'Тонно-номер', '512');
INSERT INTO public."OKEI" VALUES ('ab9378ef-c0ce-4c24-84b6-a48bb262f22b', 'Килограмм на гигакалорию', '511');
INSERT INTO public."OKEI" VALUES ('8518d41c-d069-4d91-a26a-ea74745973d2', 'Грамм на киловатт-час', '510');
INSERT INTO public."OKEI" VALUES ('7de97592-1d21-487b-b5c2-f2ca7e2b7f64', 'Тысяча наборов', '479');
INSERT INTO public."OKEI" VALUES ('65c807ae-59ec-43cc-a400-831c20758508', 'Миллион тонно-километров', '451');
INSERT INTO public."OKEI" VALUES ('d3d2bef4-1547-41fd-b3de-3c98c4446e19', 'Тысяча тонно-километров', '450');
INSERT INTO public."OKEI" VALUES ('fae935d0-f26a-41d2-a486-a3961099d7fa', 'Тонно-километр', '449');
INSERT INTO public."OKEI" VALUES ('a5cce685-87b5-47cd-8e7f-06e89395fdc6', 'Человеко-день', '540');
INSERT INTO public."OKEI" VALUES ('0670d3f9-9afb-4438-89be-974907adbeba', 'Человеко-час', '539');
INSERT INTO public."OKEI" VALUES ('2da8df29-0989-484f-9889-3fff1f7a0fc1', 'Тысяча тонн в год', '538');
INSERT INTO public."OKEI" VALUES ('c4f16766-efbc-4ec9-b653-9123e8f32b56', 'Тысяча тонн в сезон', '537');
INSERT INTO public."OKEI" VALUES ('52f0149d-baf2-4853-a757-9992bccedc93', 'Тонна в смену', '536');
INSERT INTO public."OKEI" VALUES ('1c6f90c7-ea6d-409c-bf0f-1ce16db2fa75', 'Тонна в сутки', '535');
INSERT INTO public."OKEI" VALUES ('3938f4fc-ffce-47e9-9846-dfab9ffd030d', 'Тонна в час', '534');
INSERT INTO public."OKEI" VALUES ('7778daf3-c55e-498d-905d-3ce0fd93befe', 'Человек на квадратный километр', '522');
INSERT INTO public."OKEI" VALUES ('bb256d55-b32d-4634-9820-11abe25d3fbc', 'Человек на квадратный метр', '521');
INSERT INTO public."OKEI" VALUES ('462fb781-64f8-4c36-be9d-08075fe68f83', 'Тонно-танид', '516');
INSERT INTO public."OKEI" VALUES ('66d6ecd8-53a9-4c2e-b2fd-5bf1966f9393', 'Пара в смену', '547');
INSERT INTO public."OKEI" VALUES ('82415219-3a15-4c13-991a-ac3fd5acfc64', 'Тысяча посещений в смену', '546');
INSERT INTO public."OKEI" VALUES ('6cf44fde-4689-4fd5-a263-5732953be530', 'Посещение в смену', '545');
INSERT INTO public."OKEI" VALUES ('5381d14d-4c70-4b47-88ec-f0f2a27d4030', 'Миллион единиц в год', '544');
INSERT INTO public."OKEI" VALUES ('d08f5c76-a9a5-414f-9b6b-3809170d667b', 'Тысяча условных банок в смену', '543');
INSERT INTO public."OKEI" VALUES ('4df25c82-6ea0-4e15-8353-0489a2f67402', 'Тысяча человеко-часов', '542');
INSERT INTO public."OKEI" VALUES ('1ebdbae8-0fa3-484f-a45a-369f6bc03b7f', 'Тысяча человеко-дней', '541');
INSERT INTO public."OKEI" VALUES ('24147b11-a8cc-4099-86aa-b180ff63bf89', 'Тысяча кур-несушек', '559');
INSERT INTO public."OKEI" VALUES ('d5dedeb9-0871-480e-aff2-1d8f146bdb59', 'Тысяча птицемест', '558');
INSERT INTO public."OKEI" VALUES ('84372c20-814f-47ae-92cb-01ebec83f928', 'Миллион голов в год', '557');
INSERT INTO public."OKEI" VALUES ('9feec797-dbd0-474b-a3c8-2b49b13907c1', 'Тысяча голов в год', '556');
INSERT INTO public."OKEI" VALUES ('24ac8c2b-d2ee-4b94-9789-f74be3061632', 'Тысяча центнеров переработки в сутки', '555');
INSERT INTO public."OKEI" VALUES ('83971da2-cce1-47ab-9100-83b301cb291a', 'Центнер переработки в сутки', '554');
INSERT INTO public."OKEI" VALUES ('56376391-809b-43f0-a313-bdabf1e9619c', 'Тысяча тонн переработки в сутки', '553');
INSERT INTO public."OKEI" VALUES ('13f5e069-ba1c-4480-b076-b81d07c8e48c', 'Тонна переработки в сутки', '552');
INSERT INTO public."OKEI" VALUES ('bc32842b-ab6d-44f7-a3f9-f1c09caceeb3', 'Миллион тонн в год', '550');
INSERT INTO public."OKEI" VALUES ('2eef24bf-fc3b-445a-b1d7-89aa9f4fc648', 'Тысяча пар в смену', '548');
INSERT INTO public."OKEI" VALUES ('b8db9c59-6a0f-479a-a19f-6931cea8e981', 'Миллион единиц', '644');
INSERT INTO public."OKEI" VALUES ('72f5fe1e-3f68-4a00-a584-d0dd8b91bcee', 'Тысяча единиц', '643');
INSERT INTO public."OKEI" VALUES ('f5ff2dcf-7eec-4d3d-8441-cf31073d0b4c', 'Единица', '642');
INSERT INTO public."OKEI" VALUES ('2495c9c8-5c3e-40f5-b45b-aee292617340', 'Тысяча доз', '640');
INSERT INTO public."OKEI" VALUES ('52ff99d6-3252-485a-8a46-bb486b991e0e', 'Доза', '639');
INSERT INTO public."OKEI" VALUES ('cf12f659-d6ee-4699-b9af-66629bfa62db', 'Тысяча прядильных мест', '563');
INSERT INTO public."OKEI" VALUES ('75360404-78b6-4324-94b8-6d583f0566bd', 'Тысяча прядильных веретен', '562');
INSERT INTO public."OKEI" VALUES ('0ef1faf6-4914-4d55-9e05-66aecad53e18', 'Тысяча тонн пара в час', '561');
INSERT INTO public."OKEI" VALUES ('c1eb89cb-e8c5-4f26-bc84-016acb7f3f56', 'Килобит в секунду', '2543');
INSERT INTO public."OKEI" VALUES ('f4dd9a58-b117-445d-9525-52955d2faa97', 'Бит в секунду', '2541');
INSERT INTO public."OKEI" VALUES ('6e19fd7a-aa94-480b-aabc-11a6a02e2258', 'Тысяча рулонов', '751');
INSERT INTO public."OKEI" VALUES ('e8348887-22db-4d81-80f8-fb2bfabc8359', 'Промилле (0,1 процента)', '746');
INSERT INTO public."OKEI" VALUES ('d3049c00-c810-479d-823c-6c61a55305e9', 'Процент', '744');
INSERT INTO public."OKEI" VALUES ('89995cf0-e01f-4525-bb75-cb2db3dc8cd0', 'Тысяча пачек', '729');
INSERT INTO public."OKEI" VALUES ('065f9067-05c3-407a-a1b9-9abb7ec8a2fa', 'Тысяча гектаров порций', '724');
INSERT INTO public."OKEI" VALUES ('4a738ae2-db97-40bc-8f83-da2323b63614', 'Тысяча номеров', '709');
INSERT INTO public."OKEI" VALUES ('d222699e-ad29-48f4-b7db-5505b9976639', 'Тысяча мест', '699');
INSERT INTO public."OKEI" VALUES ('f8e65ffa-3371-4e5e-b4d2-ea5871f07be4', 'Место', '698');
INSERT INTO public."OKEI" VALUES ('40ce2cbe-5dec-4fc0-88bc-a0895cb3626a', 'Тысяча комплектов', '673');
INSERT INTO public."OKEI" VALUES ('6b8f4824-f646-496c-bb75-386710114118', 'Канал', '661');
INSERT INTO public."OKEI" VALUES ('963c3e36-bff9-4b88-9f2f-0dcf52591469', 'Миллион экземпляров', '808');
INSERT INTO public."OKEI" VALUES ('ffb2cc68-edaf-4878-83dc-b561c6c0e946', 'Миллион человек', '794');
INSERT INTO public."OKEI" VALUES ('05c989c6-8745-4b41-85f3-da87584391d7', 'Тысяча человек', '793');
INSERT INTO public."OKEI" VALUES ('2e11c437-9ab1-45db-9019-779dcc0e439e', 'Человек', '792');
INSERT INTO public."OKEI" VALUES ('cf2cbedc-4741-47ce-9d5e-f406b41e9932', 'Тысяча упаковок', '782');
INSERT INTO public."OKEI" VALUES ('120e4729-c73f-41b7-86a1-14e481c2b5f0', 'Миллион упаковок', '779');
INSERT INTO public."OKEI" VALUES ('fd21e5fb-c091-4500-80e4-7d854de58381', 'Тысяча условных тубов', '776');
INSERT INTO public."OKEI" VALUES ('f8e38a9a-1b3c-400a-934b-e98888d65845', 'Тысяча тюбиков', '775');
INSERT INTO public."OKEI" VALUES ('e55b1501-0ef8-4958-b02c-aa303bcac481', 'Станция', '762');
INSERT INTO public."OKEI" VALUES ('1915ffa3-5076-4b71-ba6f-b9e7e7d1a624', 'Тысяча станов', '761');
INSERT INTO public."OKEI" VALUES ('ee3fb745-5c84-4454-8bea-4014c537134d', 'Секция', '840');
INSERT INTO public."OKEI" VALUES ('b4f44225-ba92-4a36-a5a5-9e6d7d084d15', 'Комплект', '839');
INSERT INTO public."OKEI" VALUES ('c8dd767e-417d-439e-a284-e91d7f690536', 'Миллион пар', '838');
INSERT INTO public."OKEI" VALUES ('c343a4ac-5d02-4a70-ae6b-91dfce998faf', 'Тысяча пар', '837');
INSERT INTO public."OKEI" VALUES ('b1922325-b6b2-4c24-8e20-519837ccc865', 'Голова', '836');
INSERT INTO public."OKEI" VALUES ('a766507a-34bd-4e72-badd-3f2feabf3d1d', 'Ящик', '812');
INSERT INTO public."OKEI" VALUES ('bef89430-2fe8-428a-a73a-0ba3b73d83e9', 'Ячейка', '810');
INSERT INTO public."OKEI" VALUES ('f3d5f1a2-f205-4250-97c6-878cf79a93e8', 'Тысяча условных единиц', '877');
INSERT INTO public."OKEI" VALUES ('c41c3a69-cdde-4839-9c65-1e4294e8dbdd', 'Условная единица', '876');
INSERT INTO public."OKEI" VALUES ('ee2d90ad-7c7b-416f-b712-11560acad2b7', 'Тысяча коробок', '875');
INSERT INTO public."OKEI" VALUES ('5b24f8d3-7973-4d19-9ad5-c8e57e37f428', 'Тысяча тубов', '874');
INSERT INTO public."OKEI" VALUES ('ef354bfe-7a68-4e31-8c33-cd830f31bea5', 'Тысяча флаконов', '873');
INSERT INTO public."OKEI" VALUES ('dcb96a44-f358-48b5-aa49-a8b37a335d8b', 'Флакон', '872');
INSERT INTO public."OKEI" VALUES ('2d37ace8-94d5-4a0e-95dc-35692eda125b', 'Тысяча ампул', '871');
INSERT INTO public."OKEI" VALUES ('da193273-6436-4e8b-bfdb-821b2ec2b7f5', 'Ампула', '870');
INSERT INTO public."OKEI" VALUES ('98762213-7a6a-454c-807d-1fbd47c37e10', 'Тысяча бутылок', '869');
INSERT INTO public."OKEI" VALUES ('8aa80f26-c141-45e9-8ec3-ee1883e41dcb', 'Бутылка', '868');
INSERT INTO public."OKEI" VALUES ('ccb72311-8aa5-42b6-b0fc-3d3ca373cda5', 'Условный ящик', '887');
INSERT INTO public."OKEI" VALUES ('963444a0-5023-4917-8c7d-dfe11e97945d', 'Миллион условных кусков', '886');
INSERT INTO public."OKEI" VALUES ('5628cc9c-0fd8-4152-a408-10af82706f23', 'Тысяча условных кусков', '885');
INSERT INTO public."OKEI" VALUES ('0dc7b1dd-822c-4322-80fa-dd1bd241dea2', 'Условный кусок', '884');
INSERT INTO public."OKEI" VALUES ('f44b191e-829f-4ab8-a1ed-6fb6dd2a820e', 'Миллион условных банок', '883');
INSERT INTO public."OKEI" VALUES ('18ae357d-f933-4ef9-bbc8-9be90514a502', 'Тысяча условных банок', '882');
INSERT INTO public."OKEI" VALUES ('a42d96f5-97cb-4217-b19d-9cd268a70193', 'Условная банка', '881');
INSERT INTO public."OKEI" VALUES ('6feee4fb-2816-4ea4-a69d-c1559bb02690', 'Тысяча условных штук', '880');
INSERT INTO public."OKEI" VALUES ('d7020e76-9362-470f-b721-171af16ea2df', 'Условная штука', '879');
INSERT INTO public."OKEI" VALUES ('8100c889-6645-49fa-bb67-3396b2ee0eb4', 'Миллион условных единиц', '878');
INSERT INTO public."OKEI" VALUES ('1f812e7c-6cb2-4527-a215-3d46e7360852', 'Тысяча семей', '897');
INSERT INTO public."OKEI" VALUES ('0ac3de3e-f983-47b8-a342-2a68e8e21a8f', 'Семья', '896');
INSERT INTO public."OKEI" VALUES ('0e278b3e-b6c4-49b8-99f3-2bef8333074b', 'Миллион условных кирпичей', '895');
INSERT INTO public."OKEI" VALUES ('b78ad131-2adb-4df3-8d3c-3c224d08b6c3', 'Тысяча условных кирпичей', '894');
INSERT INTO public."OKEI" VALUES ('b5c7ac9e-18a2-4275-988d-3e39a3aa38f5', 'Условный кирпич', '893');
INSERT INTO public."OKEI" VALUES ('402ee688-9a1f-4399-b211-1932fa4d56a5', 'Тысяча условных плиток', '892');
INSERT INTO public."OKEI" VALUES ('6d6c919b-5afa-4fdc-a90d-0ecf98b35c58', 'Условная плитка', '891');
INSERT INTO public."OKEI" VALUES ('b50e3187-9521-4bd6-8cef-22b4ad3c041b', 'Тысяча условных катушек', '890');
INSERT INTO public."OKEI" VALUES ('b9cdb7da-9e3d-4600-b091-f609ca21af79', 'Условная катушка', '889');
INSERT INTO public."OKEI" VALUES ('a8c6ba7c-a895-4f9b-a6b3-90f137a9dce8', 'Тысяча условных ящиков', '888');
INSERT INTO public."OKEI" VALUES ('683022cc-1adb-4c81-8ef0-b35506b7400f', 'Тысяча посадочных мест', '907');
INSERT INTO public."OKEI" VALUES ('e482f7dc-2f75-4536-8c8e-cd2fa5c32e0d', 'Посадочное место', '906');
INSERT INTO public."OKEI" VALUES ('e999a802-624f-4119-b14b-d35449de0b69', 'Тысяча рабочих мест', '905');
INSERT INTO public."OKEI" VALUES ('54a2b750-7fd9-4431-b528-ebbfb9f5ade4', 'Рабочее место', '904');
INSERT INTO public."OKEI" VALUES ('9b57a2c2-5c1c-46a0-8460-8822cf33688f', 'Тысяча ученических мест', '903');
INSERT INTO public."OKEI" VALUES ('77eced55-c4a8-4dca-9d70-90625b30b736', 'Ученическое место', '902');
INSERT INTO public."OKEI" VALUES ('2e3cc65d-ec34-47c6-918e-aca58e40c78b', 'Миллион домохозяйств', '901');
INSERT INTO public."OKEI" VALUES ('e05c1c29-84a2-430e-8985-88040ef4fc9d', 'Тысяча домохозяйств', '900');
INSERT INTO public."OKEI" VALUES ('8697e155-3190-4d50-be90-90a60222e194', 'Домохозяйство', '899');
INSERT INTO public."OKEI" VALUES ('ff01232a-3a6d-4d2c-b517-9ca2b8494ded', 'Миллион семей', '898');
INSERT INTO public."OKEI" VALUES ('cada11bd-7f79-47fa-8a2c-fb7ce2ba5692', 'Тысяча томов книжного фонда', '914');
INSERT INTO public."OKEI" VALUES ('c8c3f8f1-900a-46c6-b4ab-c52467858efd', 'Том книжного фонда', '913');
INSERT INTO public."OKEI" VALUES ('ba81ebc1-239a-433f-9f83-80234677da38', 'Тысяча коек', '912');
INSERT INTO public."OKEI" VALUES ('a8ae760f-05f5-4052-9751-e16f17c3fbc1', 'Койка', '911');
INSERT INTO public."OKEI" VALUES ('31fc400e-7fad-478a-8695-2b917a5d9312', 'Тысяча квартир', '910');
INSERT INTO public."OKEI" VALUES ('3a3a5b45-5bc5-402d-9cae-37043c207f88', 'Квартира', '909');
INSERT INTO public."OKEI" VALUES ('2525a595-24d8-4eeb-a419-977b61a82766', 'Номер', '908');
INSERT INTO public."OKEI" VALUES ('4a7fb0f5-cdfe-4218-9ad0-a9256e4bb2ff', 'Условная труба', '925');
INSERT INTO public."OKEI" VALUES ('e28a90a0-e3a9-417d-9e3a-69f6e607313a', 'Символ', '924');
INSERT INTO public."OKEI" VALUES ('2cac369c-16b5-4b40-80d4-e8dc74924464', 'Слово', '923');
INSERT INTO public."OKEI" VALUES ('94ef127d-6559-44ed-865e-612536803b47', 'Знак', '922');
INSERT INTO public."OKEI" VALUES ('f64062ce-80b5-47ee-8430-050258aadfab', 'Лист учетно-издательский', '921');
INSERT INTO public."OKEI" VALUES ('40db6e82-984f-473d-b3b1-585bc130c6a0', 'Лист печатный', '920');
INSERT INTO public."OKEI" VALUES ('c1dfbe33-1e49-404b-9d63-c81d1c904805', 'Лист авторский', '918');
INSERT INTO public."OKEI" VALUES ('207920f2-0440-4efc-8a50-b5393cde3cc0', 'Смена', '917');
INSERT INTO public."OKEI" VALUES ('d83afbb0-2770-44f5-9e69-62187a54bbbd', 'Условный ремонт в год', '916');
INSERT INTO public."OKEI" VALUES ('cd01c62b-1d2b-4b85-a631-85a60a8cd9f5', 'Условный ремонт', '915');
INSERT INTO public."OKEI" VALUES ('f37c76bf-c7d4-4e70-abfd-2a544512da75', 'Тысяча поездо-километров', '956');
INSERT INTO public."OKEI" VALUES ('e36b87c8-ac23-49df-a97c-9f438c55275d', 'Тысяча поездо-часов', '955');
INSERT INTO public."OKEI" VALUES ('939ecd8e-a747-449e-81c0-ed935b593c2a', 'Вагоно-сутки', '954');
INSERT INTO public."OKEI" VALUES ('8f6c741d-95f7-4b7b-b4c9-5a966db198ac', 'Тысяча место-километров', '953');
INSERT INTO public."OKEI" VALUES ('75cb802d-206b-4783-b305-94c74d6b3fb2', 'Тысяча вагоно-(машино)-километров', '952');
INSERT INTO public."OKEI" VALUES ('9edd32d2-a1b4-4e4d-90c9-0923a87dc1bc', 'Тысяча вагоно-(машино)-часов', '951');
INSERT INTO public."OKEI" VALUES ('bc1a25c3-2c43-4827-a92a-6cd14432dd9e', 'Вагоно(машино)-день', '950');
INSERT INTO public."OKEI" VALUES ('9c6350b1-ac78-477b-bd35-4d749a09f537', 'Миллион листов-оттисков', '949');
INSERT INTO public."OKEI" VALUES ('5a2c8caf-362a-4bef-a6cf-27104580e513', 'Миллион доз', '937');
INSERT INTO public."OKEI" VALUES ('88c062df-e622-4535-8133-932bed2798fb', 'Тысяча пластин', '930');
INSERT INTO public."OKEI" VALUES ('39810297-633b-4c45-989c-9f903f6e02be', 'Тысяча тоннаже-рейсов', '966');
INSERT INTO public."OKEI" VALUES ('dfa6c5a2-0092-406d-ac1d-26fa441d38d5', 'Тысяча километров', '965');
INSERT INTO public."OKEI" VALUES ('08a2a2ec-249b-4d96-ae28-03bc0ec6adf9', 'Самолето-километр', '964');
INSERT INTO public."OKEI" VALUES ('e3d8e9e1-b921-4a6d-8970-06289a1caf22', 'Приведенный час', '963');
INSERT INTO public."OKEI" VALUES ('cffaf58d-cda3-4399-a6d1-05462328758e', 'Тысяча автомобиле-место-дней', '962');
INSERT INTO public."OKEI" VALUES ('da93c47b-0e14-4b62-868d-f4d5c336057f', 'Тысяча автомобиле-часов', '961');
INSERT INTO public."OKEI" VALUES ('e4fdf37c-9e8e-48d9-a2c5-5dff0a5399c4', 'Тысяча автомобиле-тонно-дней', '960');
INSERT INTO public."OKEI" VALUES ('3293db84-2a7b-4049-8849-f6d5e5d507d8', 'Автомобиле-день', '959');
INSERT INTO public."OKEI" VALUES ('1aaf6b24-062f-44cf-8378-724d3db7756c', 'Тысяча пассажиро-миль', '958');
INSERT INTO public."OKEI" VALUES ('cf082053-4315-49a2-a648-5998edd9276b', 'Тысяча тонно-миль', '957');
INSERT INTO public."OKEI" VALUES ('028e403f-2c22-4b7a-97a0-9a99ed7f1954', 'Штук в 20-футовом эквиваленте (ДФЭ)', '976');
INSERT INTO public."OKEI" VALUES ('cc3aa747-e4f5-49fd-8f0b-deaa6fdbbe33', 'Суго-сутки', '975');
INSERT INTO public."OKEI" VALUES ('a4546731-4899-4dbc-85f8-41741a404e9f', 'Тысяча тоннаже-сут', '974');
INSERT INTO public."OKEI" VALUES ('451c27c2-fd13-469c-88ce-2c91895ff877', 'Тысяча автомобиле-километров', '973');
INSERT INTO public."OKEI" VALUES ('73d3317d-86f4-420c-b06f-c98e7be4443a', 'Центнер кормовых единиц', '972');
INSERT INTO public."OKEI" VALUES ('54294070-9ce8-458d-8ad2-1a0c30f9c52e', 'Кормо-день', '971');
INSERT INTO public."OKEI" VALUES ('7fc69069-efb2-4a24-a770-8bdd8129ac20', 'Миллион пассажиро-место-миль', '970');
INSERT INTO public."OKEI" VALUES ('2157ff77-f6b4-4795-9247-2bf67b96584b', 'Миллион тоннаже-миль', '969');
INSERT INTO public."OKEI" VALUES ('163de1f9-e666-427a-8b21-6dae40a75950', 'Миллион пассажиро-миль', '968');
INSERT INTO public."OKEI" VALUES ('a48a33a7-6b31-48a2-9f42-baa2f5e32e0f', 'Миллион тонно-миль', '967');
INSERT INTO public."OKEI" VALUES ('6f74bd79-c12b-49e4-8c2e-ba8d18daa10a', 'Судо-сутки', '983');
INSERT INTO public."OKEI" VALUES ('a0a763e1-c430-4366-9ee1-778ab9dfb4ac', 'Миллион тонн кормовых единиц', '982');
INSERT INTO public."OKEI" VALUES ('ba5ae689-302f-422a-9406-705066005658', 'Тысяча тонн кормовых единиц', '981');
INSERT INTO public."OKEI" VALUES ('8fab6f63-03a9-48ab-8ca8-a2f20ca7eba7', 'Тысяча долларов', '980');
INSERT INTO public."OKEI" VALUES ('305cc30f-8352-48be-bfa3-a5c1c71b02c5', 'Тысяча экземпляров', '979');
INSERT INTO public."OKEI" VALUES ('45f8c8fe-739d-4261-80b3-0fe4931d114b', 'Канало-концы', '978');
INSERT INTO public."OKEI" VALUES ('98122cf5-12a1-43d0-8b38-8a425e6a49a4', 'Канало-километр', '977');
INSERT INTO public."OKEI" VALUES ('c1964491-4ae1-4d34-ae1d-24a29be77864', 'Бушель СК (36,36874 дм3)', '140');
INSERT INTO public."OKEI" VALUES ('475de368-130c-4414-b29c-078306c8c737', 'Галлон СК (4,546092 дм3)', '139');
INSERT INTO public."OKEI" VALUES ('782ddf87-f117-4126-b054-11142dd66e93', 'Кварта СК (1,136523 дм3)', '138');
INSERT INTO public."OKEI" VALUES ('0e473df2-b203-4472-ba2a-e6c42aa710c0', 'Пинта СК (0,568262 дм3)', '137');
INSERT INTO public."OKEI" VALUES ('f3b4af51-d095-401c-ad8c-cc534f0c3f42', 'Джилл СК (0,142065 дм3)', '136');
INSERT INTO public."OKEI" VALUES ('0fb55111-938f-4fdc-b496-b62ac9ebbef0', 'Жидкостная унция СК (28,413 см3)', '135');
INSERT INTO public."OKEI" VALUES ('97409987-62e3-4c0c-ad47-e18a0d5a9769', 'Квадратная миля', '079');
INSERT INTO public."OKEI" VALUES ('1f9d3459-7d49-45c8-b8ea-5596edd4537f', 'Акр (4840 квадратных ярдов)', '077');
INSERT INTO public."OKEI" VALUES ('824f465d-ca10-46eb-afaa-ac04f90461f6', 'Миля (уставная) (1609,344 м)', '045');
INSERT INTO public."OKEI" VALUES ('231163ae-986f-4725-a9c3-293cc9ddbf02', 'Гектометр', '017');
INSERT INTO public."OKEI" VALUES ('3b3dcdcf-ac67-463b-b24c-17d815038cfb', 'Бушель США (35,2391 дм3)', '150');
INSERT INTO public."OKEI" VALUES ('9bc255a1-f243-4641-80e3-f7d503957ffe', 'Сухой галлон США (4,404884 дм3)', '149');
INSERT INTO public."OKEI" VALUES ('b9f748a8-9c89-402a-8d30-1cbf4f0754d8', 'Сухая кварта США (1,101221 дм3)', '148');
INSERT INTO public."OKEI" VALUES ('7d468d22-63bc-4eb1-9d48-ee49534c89e6', 'Сухая пинта США (0,55061 дм3)', '147');
INSERT INTO public."OKEI" VALUES ('1c7fcd7c-99f9-4b8b-b16d-b9b3a46614b6', 'Баррель (нефтяной) США (158,987 дм3)', '146');
INSERT INTO public."OKEI" VALUES ('223106c1-9c01-495d-890b-97ca97af2a53', 'Жидкостный галлон США (3,78541 дм3)', '145');
INSERT INTO public."OKEI" VALUES ('885edff0-86e5-44b4-a5a3-4f57224629c7', 'Жидкостная кварта США (0,946353 дм3)', '144');
INSERT INTO public."OKEI" VALUES ('dcaf32db-5cbf-4b2b-9abd-2c5f0b93bd23', 'Жидкостная пинта США (0,473176 дм3)', '143');
INSERT INTO public."OKEI" VALUES ('027fefb2-605c-4f8b-8aea-2d6ff11c8195', 'Джилл США (11,8294 см3)', '142');
INSERT INTO public."OKEI" VALUES ('e4b5d76a-d19c-4466-8db0-5f153708c8e7', 'Жидкостная унция США (29,5735 см3)', '141');
INSERT INTO public."OKEI" VALUES ('79e2fc0f-e04d-469b-a4ba-d59743f5bb22', 'Драхма СК (1,771745 г)', '188');
INSERT INTO public."OKEI" VALUES ('687db8c1-9dcf-4617-a7f2-4cc7e6eea5ea', 'Унция СК, США (28,349523 г)', '187');
INSERT INTO public."OKEI" VALUES ('7d6b9852-368a-423a-8346-2e2a7f761e7a', 'Фунт СК, США (0,45359237 кг)', '186');
INSERT INTO public."OKEI" VALUES ('a5b345cd-1dd3-48f5-a658-f98d1bceb94b', 'Водоизмещение', '184');
INSERT INTO public."OKEI" VALUES ('9c56dc4c-c91d-4169-9bdf-4da10a019832', 'Обмерная (фрахтовая) тонна', '183');
INSERT INTO public."OKEI" VALUES ('2abbc85c-e690-4b38-8cf7-ac25a675657d', 'Нетто-регистровая тонна', '182');
INSERT INTO public."OKEI" VALUES ('ca2f4827-bcd0-41b0-9d4c-84777399fafa', 'Тысячи бордфутов (2,36 м3)', '154');
INSERT INTO public."OKEI" VALUES ('f4672453-a1ac-42ce-90ef-66c0eee47bb6', 'Корд (3,63 м3)', '153');
INSERT INTO public."OKEI" VALUES ('8ed7ed6f-557f-49be-b81b-df99c80e15db', 'Стандарт', '152');
INSERT INTO public."OKEI" VALUES ('43eaf376-d29d-4f12-9e49-725542686517', 'Сухой баррель США (115,627 дм3)', '151');
INSERT INTO public."OKEI" VALUES ('59621b60-c97a-4134-af09-bda0d950eec3', 'Пеннивейт СК, США (1,555174 г)', '198');
INSERT INTO public."OKEI" VALUES ('9375564b-5c89-4f93-bcce-3ad1ab016c18', 'Скрупул СК, США (1,295982 г)', '197');
INSERT INTO public."OKEI" VALUES ('d6373c09-01f9-4a16-bca2-9cc6264dbf29', 'Длинная тонна СК, США (1,0160469 т) [2*]', '196');
INSERT INTO public."OKEI" VALUES ('d1f75121-6be5-4880-83a8-c259c6dd49cd', 'Короткая тонна СК, США (0,90718474 т) [2*]', '195');
INSERT INTO public."OKEI" VALUES ('15de76e7-0b79-45ca-bb70-48446bd31133', 'Длинный центнер СК (50,802345 кг)', '194');
INSERT INTO public."OKEI" VALUES ('746a3ead-f781-48f8-8c43-fa5b2f0a288b', 'Центнер США (45,3592 кг)', '193');
INSERT INTO public."OKEI" VALUES ('7e0f2d0d-f0db-4893-9d1e-0df7fcf04806', 'Центал СК (45,359237 кг)', '192');
INSERT INTO public."OKEI" VALUES ('5cadb6cb-32aa-457d-9fcc-17ed2a8275f6', 'Квартер СК (12,700586 кг)', '191');
INSERT INTO public."OKEI" VALUES ('a5e29c36-aeb5-460b-9817-9153ae458975', 'Стоун СК (6,350293 кг)', '190');
INSERT INTO public."OKEI" VALUES ('0af79df1-40e7-4c30-a2fb-b7d3bf71c4b8', 'Гран СК, США (64,798910 мг)', '189');
INSERT INTO public."OKEI" VALUES ('14b0c7a5-b864-45cf-9dd4-aac87fa549bd', 'Гросс (144 шт.)', '638');
INSERT INTO public."OKEI" VALUES ('1e880bf6-0bdc-4edd-95e0-e537becf7e5c', 'Британская тепловая единица (1,055 кДж)', '275');
INSERT INTO public."OKEI" VALUES ('c7818c62-fb13-4e50-9817-3c56ce3a35bf', 'Эффективная мощность (245,7 ватт)', '213');
INSERT INTO public."OKEI" VALUES ('f5f20cbb-78cd-4976-8964-c79ba5ea1ae8', 'Тройский фунт США (373,242 г)', '202');
INSERT INTO public."OKEI" VALUES ('be93c7fc-669e-409b-8f5a-453ce317c8f8', 'Унция СК, США (31,10348 г); тройская унция', '201');
INSERT INTO public."OKEI" VALUES ('fba4a898-22a0-4927-890f-93580e78d264', 'Драхма США (3,887935 г)', '200');
INSERT INTO public."OKEI" VALUES ('53cd96b6-54e4-419a-81c6-5d67433b273a', 'Драхма СК (3,887935 г)', '199');
INSERT INTO public."OKEI" VALUES ('b0fe2bea-3bbd-46cc-b7b8-232a9ff7b5ff', 'Килобайт в секунду', '2561');
INSERT INTO public."OKEI" VALUES ('afb82c7a-8417-4c36-bb2d-d3e57afaa935', 'Гигабайт в секунду', '2552');
INSERT INTO public."OKEI" VALUES ('f165e048-cffe-4dd4-9de9-2b3ca6653152', 'Байт в секунду', '2551');
INSERT INTO public."OKEI" VALUES ('a08cf533-1ea7-4c7a-9ea4-3bd139d7d200', 'Гигабит в секунду', '2547');
INSERT INTO public."OKEI" VALUES ('2dbb145b-5e6e-4995-9068-ae0ae6ca15db', 'Мегабит в секунду', '2545');
INSERT INTO public."OKEI" VALUES ('8e3e06c3-9db6-4550-8374-4e0cb1609689', 'Сто международных единиц', '853');
INSERT INTO public."OKEI" VALUES ('998769b7-deaa-4d56-9c19-b428c76a3c74', 'Международная единица', '851');
INSERT INTO public."OKEI" VALUES ('394041a4-8314-4343-9d46-26322a66c4c2', 'Галлон спирта установленной крепости', '835');
INSERT INTO public."OKEI" VALUES ('cb4bd79e-aa3f-47c7-8f4d-7a185c41a76f', 'Короткий стандарт (7200 единиц)', '738');
INSERT INTO public."OKEI" VALUES ('4f44ca8d-2ddb-47e2-926a-f7ecd0239a7c', 'Большой гросс (12 гроссов)', '731');
INSERT INTO public."OKEI" VALUES ('b4f01b1f-8b18-4650-a302-19121ddfb65a', 'Миллион долларов', '9802');
INSERT INTO public."OKEI" VALUES ('68b024e1-b6ef-4264-95b0-217406c79914', 'Балл', '9642');
INSERT INTO public."OKEI" VALUES ('b753a84a-cbb2-4377-aa40-994df2cc63a8', 'Миллион голов', '9557');
INSERT INTO public."OKEI" VALUES ('ddc48483-2e1b-436b-aec2-66b86bafa2df', 'Миллиард гектаров', '9062');
INSERT INTO public."OKEI" VALUES ('3ebfc400-827d-424e-8d46-1f7f10c795c0', 'Миллион гектаров', '9061');
INSERT INTO public."OKEI" VALUES ('e21ba72f-a39d-4219-ab14-2b10332e5c34', 'Абонент', '7923');
INSERT INTO public."OKEI" VALUES ('b36e6a5e-d1be-4443-a451-12b16839c533', 'Децибел', '3135');
INSERT INTO public."OKEI" VALUES ('2cef34cc-77da-409d-82a4-3d469a61f057', 'Эрланг', '2581');
INSERT INTO public."OKEI" VALUES ('6e973557-77ab-4d3e-be96-b66a3a8f8aea', 'Мегабайт в секунду', '2571');
INSERT INTO public."OKEI" VALUES ('257e0c94-3f4b-4190-922b-eba21175d4b5', 'Терабайт', '2554');
INSERT INTO public."OKEI" VALUES ('f41f829d-4ece-48ff-8ded-3bac6ba552ea', 'Гигабайт', '2553');
INSERT INTO public."OKEI" VALUES ('8a035f08-01ae-4146-94b6-3af00e875b8e', 'Пассажиро-миля', '991');
INSERT INTO public."OKEI" VALUES ('014f9f4d-acc7-4e80-81a9-02f3cd3676b8', 'Пассажиров в час', '990');
INSERT INTO public."OKEI" VALUES ('8ae77180-2ad0-4d9f-b88d-3a8872a241ba', 'Человек в час', '989');
INSERT INTO public."OKEI" VALUES ('d3f548c4-94a4-43b1-bcd0-349a2ed29479', 'Миллион условных плиток', '988');
INSERT INTO public."OKEI" VALUES ('db974436-7f86-44c5-b8fd-d7ab9c621d34', 'Миллион краско-оттисков', '987');
INSERT INTO public."OKEI" VALUES ('6ec25b08-be68-4dbd-aff6-e96c25a9e9a6', 'Тысяча краско-оттисков', '986');
INSERT INTO public."OKEI" VALUES ('5f1688f3-bcae-49f9-beee-0e364f1645e7', 'Тысяча голов', '985');
INSERT INTO public."OKEI" VALUES ('c775f1e8-a609-4311-a178-d228c2f5889e', 'Центнеров с гектара', '984');
INSERT INTO public."OKEI" VALUES ('3fe25ad4-4025-46d5-a2f8-8fd03663ea3e', 'Единиц в год', '6421');
INSERT INTO public."OKEI" VALUES ('8b8e25a4-4264-4c75-b4f3-1d3236c877cd', 'Тысяча гнезд', '5562');
INSERT INTO public."OKEI" VALUES ('cd514515-6866-48d8-b8e3-f7a1057c4d0f', 'Посещение', '5451');
INSERT INTO public."OKEI" VALUES ('83db6d3d-0946-4569-93de-fd3ad6ae18f8', 'Человек в год', '5423');
INSERT INTO public."OKEI" VALUES ('9de21396-197d-4bfb-b313-426144f408df', 'Дето-день', '5401');
INSERT INTO public."OKEI" VALUES ('54854471-e953-4e77-bb14-022fca8d11c6', 'Рубль тонна', '3831');
INSERT INTO public."OKEI" VALUES ('89a76567-8d3f-4d36-91e5-c9832fd1fffc', 'Йоттабайт', '2558');
INSERT INTO public."OKEI" VALUES ('6531dfd3-f769-4b91-95da-dc2c10edc6cb', 'Зеттабайт', '2557');
INSERT INTO public."OKEI" VALUES ('4ec8d38d-2481-4718-b80e-79ee21309479', 'Эксабайт', '2556');
INSERT INTO public."OKEI" VALUES ('d9a810ff-6563-4ce0-be54-2ddde6122265', 'Петабайт', '2555');
INSERT INTO public."OKEI" VALUES ('39b70b98-9d38-44e6-aa11-31aea9683b6b', 'Запись', '9245');
INSERT INTO public."OKEI" VALUES ('e43063be-8ce7-432c-a9c7-b48b02d8bc00', 'Пациенто-день', '9113');
INSERT INTO public."OKEI" VALUES ('080354ee-d623-41f8-8b53-2a4490fe42cb', 'Койко-день', '9111');
INSERT INTO public."OKEI" VALUES ('bfddd6cf-dc94-4b80-8f18-a99c6a9109d4', 'Коробка', '8751');
INSERT INTO public."OKEI" VALUES ('6de4fa94-ad6e-41d8-ac3c-9c5b569be0bd', 'Особь', '8361');
INSERT INTO public."OKEI" VALUES ('c528d503-bff7-45e9-a17b-c0c38bfa3f07', 'Штамм', '6424');
INSERT INTO public."OKEI" VALUES ('124ba5b6-a2a7-4a7d-adad-3f88575660e8', 'Вызов', '6422');
INSERT INTO public."OKEI" VALUES ('6760dcb0-5be1-45ed-ad96-2e8475e30a9b', 'Килобеккерель', '303');
INSERT INTO public."OKEI" VALUES ('e187667e-4ac9-42a0-9f7e-f414f12ef02f', 'Микрограмм', '164');
INSERT INTO public."OKEI" VALUES ('715671e6-0ad9-487a-b169-e8f795219c6d', 'Тысяча метров кубических в час', '508');
INSERT INTO public."OKEI" VALUES ('055fd2ed-8781-4d62-95b1-0fbdf1becb98', 'Посевная единица', '6423');
INSERT INTO public."OKEI" VALUES ('fe465e1f-3025-4d2f-ac62-47c274f9cfbf', 'Доллар за тонну', '9805');
INSERT INTO public."OKEI" VALUES ('28da00e4-eebe-460a-8691-3cd8907609c2', 'Миллиард долларов', '9803');
INSERT INTO public."OKEI" VALUES ('552f021d-48f2-44c9-86df-6f79f4e3cc94', 'Летный час', '9641');
INSERT INTO public."OKEI" VALUES ('1070fde4-8282-44e1-84a2-a48a50e38f33', 'Вагоно (машино)-час', '9501');
INSERT INTO public."OKEI" VALUES ('08cac1e0-a640-469f-bcc3-e9ed9c0dca05', 'Лист-оттиск', '9491');
INSERT INTO public."OKEI" VALUES ('2f993e30-14bf-4466-98eb-1cac4d2293b7', 'Документ', '9246');
INSERT INTO public."OKEI" VALUES ('7d4cca17-dc78-4aad-8309-bbe7588fcb6c', 'Тысяча международных единиц биологической активности на миллилитр', '9917');
INSERT INTO public."OKEI" VALUES ('481f77e9-89b9-41db-b659-ccc21e54a83f', 'Международная единица биологической активности на миллилитр', '9916');
INSERT INTO public."OKEI" VALUES ('36c9414f-b10f-4b20-9ae7-dae69213aaf9', 'Миллион международных единиц биологической активности на грамм', '9915');
INSERT INTO public."OKEI" VALUES ('4561dee0-5bf8-4c9d-ab69-523c9c843939', 'Тысяча международных единиц биологической активности на грамм', '9914');
INSERT INTO public."OKEI" VALUES ('3a1c21c5-c454-4308-82fd-462c0cf2c641', 'Международная единица биологической активности на грамм', '9913');
INSERT INTO public."OKEI" VALUES ('bf23af2c-8fd7-4eb4-ab4e-06a36eaf66a6', 'Миллион международных единиц биологической активности', '9912');
INSERT INTO public."OKEI" VALUES ('58744833-c83e-4ea2-b8a7-c7a1e3b3e7a3', 'Тысяча международных единиц биологической активности', '9911');
INSERT INTO public."OKEI" VALUES ('28932b76-789b-44bb-9726-dd315f0bd17b', 'Международная единица биологической активности', '9910');
INSERT INTO public."OKEI" VALUES ('afbf5f27-f863-4c34-9e2d-bd5a89e77a15', 'Моль', '320');
INSERT INTO public."OKEI" VALUES ('844adf04-231e-44a6-9775-467a83391cc9', 'Мегабеккерель', '307');
INSERT INTO public."OKEI" VALUES ('0c084f2f-267a-4d62-a5d9-d6e37be99415', 'Антитоксическая единица', '9930');
INSERT INTO public."OKEI" VALUES ('1a599d60-c119-4b2f-84b5-eb17b7078e30', 'Единица действия биологической активности в сутки', '9927');
INSERT INTO public."OKEI" VALUES ('25545a35-eb3e-42d7-9fce-c1cad6277c83', 'Миллион единиц действия биологической активности на миллилитр', '9926');
INSERT INTO public."OKEI" VALUES ('29934da5-2502-4620-8f72-ca19fd29ae16', 'Тысяча единиц действия биологической активности на миллилитр', '9925');
INSERT INTO public."OKEI" VALUES ('8f17897c-7ccc-4c4b-8297-72b4ed710d75', 'Единица действия биологической активности на миллилитр', '9924');
INSERT INTO public."OKEI" VALUES ('6479b0f8-3c3d-4b78-96e6-bf15eceecca9', 'Единица действия биологической активности на микролитр', '9923');
INSERT INTO public."OKEI" VALUES ('ed24d579-db11-43b8-b61b-7427b82ea8af', 'Тысяча единиц действия биологической активности на грамм', '9922');
INSERT INTO public."OKEI" VALUES ('23a1df76-f159-47fb-b3cd-fa2e92c46423', 'Единица биологической активности на грамм', '9921');
INSERT INTO public."OKEI" VALUES ('f77fb153-ebf6-44c2-8331-6d6f5ef117ed', 'Единица действия биологической активности', '9920');
INSERT INTO public."OKEI" VALUES ('8838e4b0-fdb1-4159-abc4-934fe8598d30', 'Миллион международных единиц биологической активности на миллилитр', '9918');
INSERT INTO public."OKEI" VALUES ('da5a36ee-d0a1-45cd-9097-2a4a2c7637a9', 'Тысяча калликреиновых ингибирующих единиц на миллилитр', '9971');
INSERT INTO public."OKEI" VALUES ('0343424a-178b-4393-9b0c-15e5d8788d5b', 'Калликреиновая ингибирующая единица на миллилитр', '9970');
INSERT INTO public."OKEI" VALUES ('f7adb813-0380-473b-844b-2a50aaa306cf', 'Мегабеккерель на метр квадратный', '9962');
INSERT INTO public."OKEI" VALUES ('c6112dda-4355-4fa0-8333-d168c2fb9909', 'Мегабеккерель на миллилитр', '9961');
INSERT INTO public."OKEI" VALUES ('c1e06f7c-105b-47c3-89e4-3676836dda2d', 'Килобеккерель на миллилитр', '9960');
INSERT INTO public."OKEI" VALUES ('66fe5c49-f7df-45ad-b027-40ca7654eede', 'Индекс Реактивности на миллилитр', '9951');
INSERT INTO public."OKEI" VALUES ('4e579dd9-66b0-420b-aaef-d0fb362f26ea', 'Индекс Реактивности', '9950');
INSERT INTO public."OKEI" VALUES ('0b458e86-80f0-4e72-b028-29571ceeb379', 'Тысяча антитрипсиновых единиц', '9941');
INSERT INTO public."OKEI" VALUES ('6f35ea05-9aad-4264-8691-016cd61cb1f4', 'Антитрипсиновая единица', '9940');
INSERT INTO public."OKEI" VALUES ('6c939825-57e5-4c18-87fe-2c2c03bca96b', 'Тысяча антитоксических единиц', '9931');
INSERT INTO public."OKEI" VALUES ('092c92c9-eacc-4023-825b-6629847928fc', 'Микрограмм в час', '9987');
INSERT INTO public."OKEI" VALUES ('f6f61d8c-ebc2-407b-aef6-e48b6569fd59', 'Микрограмм в сутки', '9986');
INSERT INTO public."OKEI" VALUES ('b06e865b-7692-41d0-b101-8699bace09f3', 'Микрограмм на миллилитр', '9985');
INSERT INTO public."OKEI" VALUES ('2b32ba18-8907-4ab9-b53e-d116fe08e4d5', 'Протеолитическая единица', '9983');
INSERT INTO public."OKEI" VALUES ('40eac6e8-b121-4a42-bad1-cd5ab64ce2b6', 'Миллиард колониеобразующих единиц', '9982');
INSERT INTO public."OKEI" VALUES ('d0545849-fce2-4dea-960e-925e2423bf98', 'Миллион колониеобразующих единиц на пакет', '9981');
INSERT INTO public."OKEI" VALUES ('7d244e15-0ec4-4f1b-a086-94b99d06721d', 'Миллион колониеобразующих единиц', '9980');
INSERT INTO public."OKEI" VALUES ('235912eb-603a-4283-8d81-6ab07c356892', 'Терагерц', '295');
INSERT INTO public."OKEI" VALUES ('5dd905b1-c31f-4cc7-8968-8d8681d122c5', 'Гигагерц', '293');
INSERT INTO public."OKEI" VALUES ('942afa15-74f1-447e-bc3b-82364b2267be', 'Килогрей', '279');
INSERT INTO public."OKEI" VALUES ('21edaabe-89fd-4c11-adc1-21608fd4c6a0', 'Миллигрей', '278');
INSERT INTO public."OKEI" VALUES ('55a06d3e-be7a-4655-ad2d-8ee6089c0bba', 'Микрогрей', '277');
INSERT INTO public."OKEI" VALUES ('7637fa19-9e7f-40bb-b46d-97c891cf9577', 'Километр в сутки', '509');
INSERT INTO public."OKEI" VALUES ('f440b635-0353-4512-b2fe-ac48ff4881f6', 'Пачка', '728');
INSERT INTO public."OKEI" VALUES ('63e6f7ea-62d3-4e3c-a29f-49f6f5365ad2', 'Миллимоль на литр', '9991');
INSERT INTO public."OKEI" VALUES ('7ed97e37-81bd-42a2-a229-e149e391d3ae', 'Миллимоль на миллилитр', '9990');
INSERT INTO public."OKEI" VALUES ('0cd96cd2-f877-42ca-aa5f-a50342b3c115', 'Микрограмм на дозу', '9988');
INSERT INTO public."OKEI" VALUES ('c95921c8-d0ae-48f8-9cca-e991f8f4b79a', 'Микрогрей в секунду', '2314');
INSERT INTO public."OKEI" VALUES ('e253556a-23da-478b-b35d-0fedf4f3019a', 'Грей в час', '2313');
INSERT INTO public."OKEI" VALUES ('a3444a4a-a4fd-4385-bc20-1d2d8bfcb019', 'Грей в минуту', '2312');
INSERT INTO public."OKEI" VALUES ('7d299fbd-bc91-498e-b7d5-42a91ebace34', 'Грей в секунду', '2311');
INSERT INTO public."OKEI" VALUES ('683922ba-4029-4f21-8cdf-7fd01c23f465', 'Пикосекунда', '350');
INSERT INTO public."OKEI" VALUES ('032f8d56-a019-4b8c-9a59-1d90d6bf907b', 'Фемтосекунда', '348');
INSERT INTO public."OKEI" VALUES ('396b4ace-39e1-42ee-92cf-fd04396e324e', 'Миллизиверт', '321');
INSERT INTO public."OKEI" VALUES ('dab82224-7539-4387-9972-d9f64e3387e0', 'Микрозиверт', '319');
INSERT INTO public."OKEI" VALUES ('27422dbb-e674-49af-862c-88ea91427e76', 'Зиверт', '318');
INSERT INTO public."OKEI" VALUES ('59924c18-7dc6-4de4-a74e-8fd1c98379c4', 'Наносекунда', '351');
INSERT INTO public."OKEI" VALUES ('e8cf4037-1ad7-41d9-86c5-09c634824455', 'Пар грузовых поездов в сутки', '426');
INSERT INTO public."OKEI" VALUES ('22b701e4-57b8-4f53-a284-0af02b491d5c', 'Секунда (плоского угла)', '2357');
INSERT INTO public."OKEI" VALUES ('afcc0bf3-0340-4fae-9718-0b98b1d7146b', 'Минута (плоского угла)', '2356');
INSERT INTO public."OKEI" VALUES ('f3031bd6-3960-465e-83e6-d1da02fd45c4', 'Градус (плоского угла)', '2355');
INSERT INTO public."OKEI" VALUES ('793ffa71-5848-4488-a0b8-34c766c0e6b5', 'Миллизиверт в час', '2354');
INSERT INTO public."OKEI" VALUES ('90a65d92-7428-4a08-9f17-f4dc8ee324ad', 'Микрозиверт в час', '2353');
INSERT INTO public."OKEI" VALUES ('9a388dbb-b8c2-44e4-8f7e-033ab8768486', 'Микрозиверт в секунду', '2352');
INSERT INTO public."OKEI" VALUES ('1feed902-29bd-4c64-80a9-ecdf63362cfe', 'Зиверт в час', '2351');
INSERT INTO public."OKEI" VALUES ('2e084b04-7d70-4d7b-b258-2219967879c9', 'Миллигрей в час', '2316');
INSERT INTO public."OKEI" VALUES ('889e5d4d-c5eb-4dcf-aeb2-462ebff5b0d5', 'Микрогрей в час', '2315');
INSERT INTO public."OKEI" VALUES ('a5ea06d5-c3c7-43bf-b934-8b494922ddef', 'Беккерель на метр кубический', '3231');
INSERT INTO public."OKEI" VALUES ('f535539a-4164-43c0-995e-9084b6cbdd95', 'Человеко-зиверт', '3181');
INSERT INTO public."OKEI" VALUES ('50c8c1dd-beec-40b3-aa5d-f25001127416', 'Миллион евро', '9822');
INSERT INTO public."OKEI" VALUES ('b263ebbc-460e-424c-9633-186d0d88b1d3', 'Миллиард евро', '9823');
INSERT INTO public."OKEI" VALUES ('4fc70a50-6e2b-4812-ad81-e6b8a21105cf', 'Килограмм условного топлива на гигакалорию', '341');
INSERT INTO public."OKEI" VALUES ('2b590071-20be-48a5-a3c9-6c4027004d83', 'Грамм условного топлива на киловатт-час', '340');
INSERT INTO public."OKEI" VALUES ('df94b169-a91d-46be-8cb9-5508dcd7d12a', 'Базисный пункт', '747');


--
-- Data for Name: OKS; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ParticipantResponsibilityLevel; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."ParticipantResponsibilityLevel" VALUES ('ac064980-eb0e-4a86-bf41-7991495e4250', 'Согласование', 'Согласование');
INSERT INTO public."ParticipantResponsibilityLevel" VALUES ('9e79c82b-431f-4339-a2d1-52dfb85f8e65', 'Нормоконтроль', 'Нормоконтроль');
INSERT INTO public."ParticipantResponsibilityLevel" VALUES ('e6a97421-82eb-48b6-ba71-e2abd70cf6d0', 'Разработка', 'Разработка');


--
-- Data for Name: PrivateSource; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ProjectDocParticipant; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ProjectDocumentationLink; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Resource; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Route; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Row; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: SROType; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."SROType" VALUES ('2f550b70-537b-4018-8257-d865e234a7e7', 'Саморегулируемая организация в области строительства', 'Саморегулируемая организация в области строительства');
INSERT INTO public."SROType" VALUES ('4574d247-8cf0-483c-8c86-900f73ed4c37', 'Саморегулируемая организация в области архитектурно-строительного проектирования', 'Саморегулируемая организация в области архитектурно-строительного проектирования');
INSERT INTO public."SROType" VALUES ('6d817f63-b9ed-47e4-a8fc-502f5a583f8b', 'Саморегулируемая организация в области инженерных изысканий', 'Саморегулируемая организация в области инженерных изысканий');


--
-- Data for Name: SRO; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: SignFile; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Software; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Stage; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: TechnicalCustomer; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: StateCustomerSource; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: TEI; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Table; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: UsedNorm; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: WorkPerson; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- PostgreSQL database dump complete
--


using Microsoft.EntityFrameworkCore.Migrations;

namespace KLADobj.WebService.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KLADobjs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    AdmArea = table.Column<string>(nullable: true),
                    ObjectStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KLADobjs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 1L, "Московская область, г. Домодедово, вблизи д. Истомиха, территория \"Домодедовское кладбище\"", null, "Домодедовское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 103L, "деревня Спас-Купля", "Троицкий административный округ", "Спас-Купля кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 102L, "деревня Сосенки", "Новомосковский административный округ", "Сосенское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 101L, "деревня Середнево", "Новомосковский административный округ", "Середневское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 100L, "село Свитино", "Троицкий административный округ", "Свитино кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 99L, "деревня Сатино-Русское", "Троицкий административный округ", "Сатино-Русское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 98L, "деревня Сальково", "Троицкий административный округ", "Сальково кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 97L, "деревня Саларьево, дом 9", "Новомосковский административный округ", "Саларьевское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 96L, "деревня Руднево", "Троицкий административный округ", "Руднево кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 95L, "поселение Сосенское, в районе Николо-Хованского кладбища, уч. № 27", "Новомосковский административный округ", "Николо-Хованское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 94L, "деревня Рождественно", "Троицкий административный округ", "Рождественно кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 93L, "улица Войтовича, вл. 31А", "Юго-Восточный административный округ", "Рогожское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 92L, "в районе д. Десна", "Новомосковский административный округ", "Ракитки кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 91L, "Олонецкий проезд, дом 4, корпус 2", "Северо-Восточный административный округ", "Раевское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 90L, "деревня Раево, строение 1", "Троицкий административный округ", "Раево кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 89L, "Дроболитейный переулок, дом 3, строение 1", "Северо-Восточный административный округ", "Пятницкое кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 88L, "деревня Пыхтино", "Новомосковский административный округ", "Пыхтинское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 87L, "деревня Пучково", "Троицкий административный округ", "Пучково кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 73L, "Лужнецкий проезд, вл. 2", "Центральный административный округ", "Новодевичье кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 74L, "Шипиловский проезд, вл. 20", "Южный административный округ", "Ореховское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 75L, "Староорловская улица", "Западный административный округ", "Орловское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 76L, "Прудовой проезд, вл. 11", "Северо-Восточный административный округ", "Останкинское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 77L, "вблизи с. Остафьево", "Новомосковский административный округ", "Остафьево кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 78L, "г. Московский", "Новомосковский административный округ", "Передельцевское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 104L, "деревня Станиславль", "Новомосковский административный округ", "Станиславское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 79L, "Московская область, Солнечногорский район, с.п. Луневское, д. Перепечино", null, "Перепечинское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 81L, "Кетчерская улица, вл. 20", "Восточный административный округ", "Перовское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 82L, "деревня Песье", "Троицкий административный округ", "Песье кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 83L, "улица Подольских Курсантов, вл. 24", "Южный административный округ", "Покровское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 84L, "деревня Поповка", "Троицкий административный округ", "Поповка кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 85L, "улица Преображенский вал, вл. 17А", "Восточный административный округ", "Преображенское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 86L, "деревня Прокшино", "Новомосковский административный округ", "Прокшинское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 80L, "92 километр Московской Кольцевой Автодороги", "Северо-Восточный административный округ", "Перловское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 72L, "улица Сущевский вал, вл. 19", "Северо-Восточный административный округ", "Миусское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 105L, "Дмитровское шоссе, владение 124А", "Северо-Восточный административный округ", "Старо-Марковское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 107L, "дер. Товарищево", "Троицкий административный округ", "Товарищево-1 кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 138L, "Дмитровское шоссе, владение 162", "Северо-Восточный административный округ", "Виноградово кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 137L, "д. Былово", "Троицкий административный округ", "Былово-1 кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 136L, "г. Щербинка, ул. Весенняя", "Троицкий административный округ", "Барыши кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 135L, "п. Краснопахорское, вблизи д. Подосинки", "Троицкий административный округ", "Троицкое городское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 134L, "Московская обл., Одинцовский р-н", null, "Ястребковское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 133L, "пос. ДСК \"Мичуринец\"", "Новомосковский административный округ", "Переделкинское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 132L, "деревня Большое Покровское", "Новомосковский административный округ", "Большое Покровское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 131L, "Проектируемый проезд № 5363, Черкизовское кладбище, дом 1 ", "Северный административный округ", "Черкизовское (северное) кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 130L, "Рябиновая ул., д. 24 стр.1", "Западный административный округ", "Троекуровское трупохранилище", null });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 129L, "ул. Сергея Макеева, вл. 10", "Центральный административный округ", "Ваганьковское (Армянский участок) кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 128L, "дер. Ямонтово", "Новомосковский административный округ", "Ивановское (п.Сосенское) кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 127L, "село Никольское", "Троицкий административный округ", "Никольское (п.Вороновское) кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 126L, "1-я Муравская улица. вл. 39", "Северо-Западный административный округ", "Рождественское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 125L, "Большая Черкизовская ул., вл. 15", "Восточный административный округ", "Черкизовское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 124L, "Московская область, Балашихинский район, г. Балашиха, мкр-н Салтыковка, ул. Окольная владение 4", null, "Николо-Архангельский крематорий", null });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 123L, "кладбище Хованское, стр.1", "Новомосковский административный округ", "Хованский крематорий", null });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 122L, "Московская область, Красногорский район, Пятницкое шоссе, 6-й км", null, "Митинский крематорий", null });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 108L, "Рябиновая улица, вл. 24", "Западный административный округ", "Троекуровское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 109L, "улица Твардовского, вл. 12, корпус 3", "Северо-Западный административный округ", "Троице-Лыковское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 110L, "поселок Филимонки", "Новомосковский административный округ", "Филимонковское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 111L, "деревня Хатминки", "Троицкий административный округ", "Хатминки кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 112L, "Новосходненское шоссе, вл. 1", "Северный административный округ", "Химкинское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 113L, "поселение \"Мосрентген\", 21-й км Киевского ш.", "Новомосковский административный округ", "Хованское (Центральное) кладбище", "открытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 106L, "1-й Дорожный проезд, вл. 10", "Южный административный округ", "Старо-Покровское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 114L, "поселение \"Мосрентген\", 21-й км Киевского ш.", "Новомосковский административный округ", "Хованское (Северное) кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 116L, "Южное Бутово, по улице Южнобутовской", "Юго-Западный административный округ", "Черневское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 117L, "деревня Чириково", "Троицкий административный округ", "Чириково кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 118L, "поселок Щапово", "Троицкий административный округ", "Щапово кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 119L, "деревня Юдановка", "Троицкий административный округ", "Юдановка кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 120L, "Новоясеневский проспект, вл. 42", "Юго-Западный административный округ", "Ясеневское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 121L, "деревня Яковлево", "Новомосковский административный округ", "Яковлевское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 115L, "поселение Сосенское, Хованское Западное кладбище", "Новомосковский административный округ", "Хованское (Западное) кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 71L, "деревня Кленово", "Троицкий административный округ", "Кленово кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 70L, "Зеленоград, Проезд N 4921, дом 3, строение 1, 2", "Зеленоградский административный округ", "Зеленоградское (Центральное) кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 69L, "Донская площадь, владение 1", "Южный административный округ", "Донское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 32L, "Краснобогатырская улица, вл. 81", "Восточный административный округ", "Богородское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 31L, "деревня Богородское", "Троицкий административный округ", "Богородское (д. Богородское) кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 30L, "деревня Белоусово", "Троицкий административный округ", "Белоусово кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 29L, "Ярославское шоссе, владение 52", "Северо-Восточный административный округ", "Бабушкинское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 28L, "деревня Анкудиново", "Новомосковский административный округ", "Анкудиново кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 27L, "85-й км МКАД", "Северо-Восточный административный округ", "Алтуфьевское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 26L, "Проспект Мира, владение 132", "Северо-Восточный административный округ", "Алексеевское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 25L, "г. Зеленоград, промзона «Алабушево»", "Зеленоградский административный округ", "Алабушевское кладбище", "открытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 24L, "деревня Лукошкино", "Троицкий административный округ", "Лукошкино кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 23L, "Московская область, Мытищинский район, юго-западная часть городского поселения Мытищи, 83-й км МКАД", null, "Лианозовское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 22L, "д. Летово", "Новомосковский административный округ", "Летовское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 21L, "1-я улица Леонова, вл. 8", "Северо-Восточный административный округ", "Леоновское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 20L, "поселок Рублево", "Западный административный округ", "Рублевское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 19L, "улица Академика Скрябина, вл. 19", "Юго-Восточный административный округ", "Кузьминское (мусульманское) кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 18L, "улица Академика Скрябина, вл. 19", "Юго-Восточный административный округ", "Кузьминское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 17L, "деревня Кузнецово", "Троицкий административный округ", "Кузнецово кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 16L, "деревня Кувекино", "Новомосковский административный округ", "Кувекинское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 2L, "деревня Жохово", "Троицкий административный округ", "Жохово кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 3L, "улица Николая Сироткина", "Юго-Западный административный округ", "Захарьинское кладбище", "открытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 4L, "Зеленоград, Проезд N 710, дом 19 стр. 1, 3, 4", "Зеленоградский административный округ", "Зеленоградское (Северное) кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 5L, "поселок Зосимова пустынь", "Троицкий административный округ", "Зосимова пустынь кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 6L, "улица Сталеваров, владение 6, стр. 1,2,3,4,5,6", "Восточный административный округ", "Ивановское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 7L, "деревня Изварино", "Новомосковский административный округ", "Изваринское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 33L, "село Богоявление", "Троицкий административный округ", "Богоявление кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 8L, "вблизи с. Ознобишино", "Троицкий административный округ", "Ознобишино кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 10L, "Большой Калитниковский проезд, вл. 11", "Центральный административный округ", "Калитниковское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 11L, "1-й квартал Капотня, 1-й Капотнинский проезд", "Юго-Восточный административный округ", "Капотненское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 12L, "Старокачаловская улица, владение 8", "Юго-Западный административный округ", "Качаловское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 13L, "деревня Клоково", "Троицкий административный округ", "Клоково кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 14L, "улица Деловая, вл. 21", "Южный административный округ", "Котляковское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 15L, "село Красное", "Троицкий административный округ", "Красное кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 9L, "д. Исаково", "Троицкий административный округ", "Исаково кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 34L, "Наличная ул., вл. 1", "Юго-Восточный административный округ", "Введенское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 35L, "деревня Большое Свинорье", "Новомосковский административный округ", "Большое Свинорье кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 36L, "Борисовские Пруды улица, вл. 4", "Южный административный округ", "Борисовское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 55L, "4-й Рощинский проезд, вл. 30", "Южный административный округ", "Даниловское (Центральное) кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 56L, "2-й Рощинский проезд, вл. 10", "Южный административный округ", "Даниловское (мусульманское) кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 57L, "дер. Девятское", "Новомосковский административный округ", "Девятское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 58L, "Московская область, г. Долгопрудный, Лихачевский проезд", null, "Долгопрудненское (Центральное) кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 59L, "Рябиновая улица, вл. 20", "Западный административный округ", "Кунцевское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 60L, "Ставропольская улица, вл. 74А", "Юго-Восточный административный округ", "Люблинское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 54L, "деревня Губцево", "Троицкий административный округ", "Губцево кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 61L, "деревня Маврино", "Троицкий административный округ", "Маврино кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 63L, "Зеленоград, Московский проспект", "Зеленоградский административный округ", "Никольское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 64L, "Московская область, Подольский район, сельское поселение Стрелковское, 29 км автодороги М-2 \"Крым\", Щербинский проезд", null, "Щербинское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 65L, "Московская область, Балашихинский район, с. Никольско-Архангельское ", null, "Николо-Архангельское (Центральное), Николо-Архангельское (Восточное) кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 66L, "поселение Сосенское, в районе Николо-Хованского кладбища", "Новомосковский административный округ", "Николо-Хованское-1 кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 67L, "дер. Новогромово", "Троицкий административный округ", "Новогромово кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 68L, "Московская область, Красногорский муниципальный район, сельское поселение Отрадненское, Пятницкое шоссе, 6-й км", null, "Митинское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 62L, "Заповедная улица, владение 7А", "Северо-Восточный административный округ", "Медведковское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 139L, "д. Романцево", "Троицкий административный округ", "Романцево кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 53L, "Курганская улица, вл. 11", "Восточный административный округ", "Гольяновское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 51L, "Озерная улица, вл. 47, корпус 3, 4, 5, 6, 7, 8", "Западный административный округ", "Востряковское (Северное) кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 37L, "улица Краснополянская, вл. 18", "Северный административный округ", "Бусиновское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 38L, "Южное Бутово, 36-й км Курской ж/д", "Юго-Западный административный округ", "Бутовское кладбище", "открытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 39L, "село Былово", "Троицкий административный округ", "Былово кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 40L, "ул. Сергея Макеева, вл. 15", "Центральный административный округ", "Ваганьковское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 41L, "Головинское шоссе, вл. 13", "Северный административный округ", "Головинское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 42L, "деревня Варварино", "Троицкий административный округ", "Варварино кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 52L, "Измайловский проезд, владение 30", "Восточный административный округ", "Измайловское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 43L, "деревня Васюнино", "Троицкий административный округ", "Васюнино кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 45L, "Московская область, г. Долгопрудный, Лихачевский проспект", null, "Долгопрудненское (Южное) кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 46L, "Юности улица, дом 17", "Восточный административный округ", "Вешняковское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 47L, "Станционная улица, дом 8А", "Северо-Восточный административный округ", "Владыкинское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 48L, "вблизи с. Вороново", "Троицкий административный округ", "Вороново кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 49L, "деревня Ворсино", "Троицкий административный округ", "Ворсино кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 50L, "Озерная улица, вл. 47, корпус 3, 4, 5, 6, 7, 8", "Западный административный округ", "Востряковское (Центральное) кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 44L, "поселок Ватутинки", "Новомосковский административный округ", "Ватутинское кладбище", "закрытое" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "AdmArea", "Name", "ObjectStatus" },
                values: new object[] { 140L, "Боровское шоссе, проектируемый проезд № 634", "Западный административный округ", "Востряковское (Южное) иудейское кладбище", "открытое" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KLADobjs");
        }
    }
}

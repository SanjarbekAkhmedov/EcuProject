using System.ComponentModel.DataAnnotations.Schema;

namespace EcuProject.Model;

[Table("app_ecu")]
public partial class AppEcu
{
    [Column("id")]
    public int Id { get; set; }

    [Column("ecu_type")]
    public int EcuType { get; set; }

    [Column("ecu_producer")]
    public int EcuProducer { get; set; }

    [Column("carmaker")]
    public int Carmaker { get; set; }

    [Column("ecumodel")]
    public int Ecumodel { get; set; }

    [Column("ecu_cpu1")]
    public int? EcuCpu1 { get; set; }

    [Column("cpu1type")]
    public int? Cpu1type { get; set; }

    [Column("flash")]
    public int? Flash { get; set; }

    [Column("flashsizefull")]
    public int? Flashsizefull { get; set; }

    [Column("flashsizecal")]
    public int? Flashsizecal { get; set; }

    [Column("flashsizecal2")]
    public int? Flashsizecal2 { get; set; }

    [Column("eeprom")]
    public int? Eeprom { get; set; }

    [Column("eepromsize")]
    public int? Eepromsize { get; set; }

    [Column("hw1")]
    public int? Hw1 { get; set; }

    [Column("hw2")]
    public int? Hw2 { get; set; }

    [Column("hw3")]
    public int? Hw3 { get; set; }

    [Column("infolink")]
    public string? Infolink { get; set; }

    [Column("tprot")]
    public int? Tprot { get; set; }

    [Column("sw1")]
    public int? Sw1 { get; set; }

    [Column("sw2")]
    public int? Sw2 { get; set; }

    [Column("sw3")]
    public int? Sw3 { get; set; }

    [Column("swver")]
    public int? Swver { get; set; }

    [Column("tune1_use")]
    public int? Tune1Use { get; set; }

    [Column("tune1_cars")]
    public string? Tune1Cars { get; set; }

    [Column("tune1_price")]
    public int? Tune1Price { get; set; }

    [Column("adblue_use")]
    public int? AdblueUse { get; set; }

    [Column("adblue_cars")]
    public string? AdblueCars { get; set; }

    [Column("adblue_price")]
    public string? AdbluePrice { get; set; }

    [Column("dpf_use")]
    public int? DpfUse { get; set; }

    [Column("dpf_cars")]
    public string? DpfCars { get; set; }

    [Column("dpf_price")]
    public string? DpfPrice { get; set; }

    [Column("egr_use")]
    public int? EgrUse { get; set; }

    [Column("egr_car")]
    public string? EgrCar { get; set; }

    [Column("egr_price")]
    public string? EgrPrice { get; set; }

    [Column("tva_use")]
    public int? TvaUse { get; set; }

    [Column("tva_cars")]
    public string? TvaCars { get; set; }

    [Column("tva_price")]
    public string? TvaPrice { get; set; }

    [Column("flaps_use")]
    public int? FlapsUse { get; set; }

    [Column("flaps_cars")]
    public string? FlapsCars { get; set; }

    [Column("flaps_price")]
    public string? FlapsPrice { get; set; }

    [Column("lambda_use")]
    public int? LambdaUse { get; set; }

    [Column("lambda_cars")]
    public string? LambdaCars { get; set; }

    [Column("lambda_price")]
    public string? LambdaPrice { get; set; }

    [Column("e2_use")]
    public int? E2Use { get; set; }

    [Column("e2_cars")]
    public string? E2Cars { get; set; }

    [Column("e2_price")]
    public string? E2Price { get; set; }

    [Column("startstop_use")]
    public int? StartstopUse { get; set; }

    [Column("startstop_cars")]
    public string? StartstopCars { get; set; }

    [Column("startstop_price")]
    public string? StartstopPrice { get; set; }

    [Column("maf_use")]
    public int? MafUse { get; set; }

    [Column("maf_cars")]
    public string? MafCars { get; set; }

    [Column("maf_price")]
    public string? MafPrice { get; set; }

    [Column("immo_virg_use")]
    public string? ImmoVirgUse { get; set; }

    [Column("immo_virg_cars")]
    public string? ImmoVirgCars { get; set; }

    [Column("immo_virg_price")]
    public string? ImmoVirgPrice { get; set; }

    [Column("immo_learn_use")]
    public string? ImmoLearnUse { get; set; }

    [Column("immo_learn_cars")]
    public string? ImmoLearnCars { get; set; }

    [Column("immo_learn_price")]
    public string? ImmoLearnPrice { get; set; }

    [Column("readiness_use")]
    public string? ReadinessUse { get; set; }

    [Column("readiness_cars")]
    public string? ReadinessCars { get; set; }

    [Column("readiness_price")]
    public string? ReadinessPrice { get; set; }

    [Column("comments")]
    public string? Comments { get; set; }
}

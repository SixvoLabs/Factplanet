namespace FbJson
{
    public class Rootobject
    {
        public Introduction Introduction { get; set; }
        public Geography Geography { get; set; }
        public PeopleAndSociety PeopleandSociety { get; set; }
        public Government Government { get; set; }
        public Economy Economy { get; set; }
        public Energy Energy { get; set; }
        public Communications Communications { get; set; }
        public Transportation Transportation { get; set; }
        public MilitaryAndSecurity MilitaryandSecurity { get; set; }
        public TransnationalIssues TransnationalIssues { get; set; }
    }

    public class Introduction
    {
        public Background Background { get; set; }
    }

    public class Background
    {
        public string text { get; set; }
    }

    public class Geography
    {
        public Location Location { get; set; }
        public GeographicCoordinates Geographiccoordinates { get; set; }
        public MapReferences Mapreferences { get; set; }
        public Area Area { get; set; }
        public AreaComparative Areacomparative { get; set; }
        public LandBoundaries Landboundaries { get; set; }
        public Coastline Coastline { get; set; }
        public MaritimeClaims Maritimeclaims { get; set; }
        public Climate Climate { get; set; }
        public Terrain Terrain { get; set; }
        public Elevation Elevation { get; set; }
        public NaturalResources Naturalresources { get; set; }
        public LandUse Landuse { get; set; }
        public IrrigatedLand Irrigatedland { get; set; }
        public PopulationDistribution Populationdistribution { get; set; }
        public NaturalHazards Naturalhazards { get; set; }
        public EnvironmentCurrentIssues Environmentcurrentissues { get; set; }
        public EnvironmentInternationalAgreements Environmentinternationalagreements { get; set; }
        public GeographyNote Geographynote { get; set; }
    }

    public class Location
    {
        public string text { get; set; }
    }

    public class GeographicCoordinates
    {
        public string text { get; set; }
    }

    public class MapReferences
    {
        public string text { get; set; }
    }

    public class Area
    {
        public Total total { get; set; }
        public Land land { get; set; }
        public Water water { get; set; }
    }

    public class Total
    {
        public string text { get; set; }
    }

    public class Land
    {
        public string text { get; set; }
    }

    public class Water
    {
        public string text { get; set; }
    }

    public class AreaComparative
    {
        public string text { get; set; }
    }

    public class LandBoundaries
    {
        public Total1 total { get; set; }
        public BorderCountries bordercountries { get; set; }
    }

    public class Total1
    {
        public string text { get; set; }
    }

    public class BorderCountries
    {
        public string text { get; set; }
    }

    public class Coastline
    {
        public string text { get; set; }
    }

    public class MaritimeClaims
    {
        public TerritorialSea territorialsea { get; set; }
        public ExclusiveFishingZone exclusivefishingzone { get; set; }
    }

    public class TerritorialSea
    {
        public string text { get; set; }
    }

    public class ExclusiveFishingZone
    {
        public string text { get; set; }
    }

    public class Climate
    {
        public string text { get; set; }
    }

    public class Terrain
    {
        public string text { get; set; }
    }

    public class Elevation
    {
        public MeanElevation meanelevation { get; set; }
        public ElevationExtremes elevationextremes { get; set; }
    }

    public class MeanElevation
    {
        public string text { get; set; }
    }

    public class ElevationExtremes
    {
        public string text { get; set; }
    }

    public class NaturalResources
    {
        public string text { get; set; }
    }

    public class LandUse
    {
        public AgriculturalLand agriculturalland { get; set; }
        public Forest forest { get; set; }
        public Other other { get; set; }
    }

    public class AgriculturalLand
    {
        public string text { get; set; }
    }

    public class Forest
    {
        public string text { get; set; }
    }

    public class Other
    {
        public string text { get; set; }
    }

    public class IrrigatedLand
    {
        public string text { get; set; }
    }

    public class PopulationDistribution
    {
        public string text { get; set; }
    }

    public class NaturalHazards
    {
        public string text { get; set; }
    }

    public class EnvironmentCurrentIssues
    {
        public string text { get; set; }
    }

    public class EnvironmentInternationalAgreements
    {
        public PartyTo partyto { get; set; }
        public SignedButNotRatified signedbutnotratified { get; set; }
    }

    public class PartyTo
    {
        public string text { get; set; }
    }

    public class SignedButNotRatified
    {
        public string text { get; set; }
    }

    public class GeographyNote
    {
        public string text { get; set; }
    }

    public class PeopleAndSociety
    {
        public Population Population { get; set; }
        public Nationality Nationality { get; set; }
        public EthnicGroups Ethnicgroups { get; set; }
        public Languages Languages { get; set; }
        public Religions Religions { get; set; }
        public DemographicProfile Demographicprofile { get; set; }
        public AgeStructure Agestructure { get; set; }
        public DependencyRatios Dependencyratios { get; set; }
        public MedianAge Medianage { get; set; }
        public PopulationGrowthRate Populationgrowthrate { get; set; }
        public BirthRate Birthrate { get; set; }
        public DeathRate Deathrate { get; set; }
        public NetMigrationRate Netmigrationrate { get; set; }
        public PopulationDistribution Populationdistribution;
        public Urbanization Urbanization { get; set; }
        public MajorUrbanAreasPopulation Majorurbanareaspopulation { get; set; }
        public SexRatio Sexratio { get; set; }
        public MaternalMortalityRate Maternalmortalityrate { get; set; }
        public InfantMortalityRate Infantmortalityrate { get; set; }
        public LifeExpectancyAtBirth Lifeexpectancyatbirth { get; set; }
        public TotalFertilityRate Totalfertilityrate { get; set; }
        public ContraceptivePrevalenceRate Contraceptiveprevalencerate { get; set; }
        public HealthExpenditures Healthexpenditures { get; set; }
        public PhysiciansDensity Physiciansdensity { get; set; }
        public DrinkingWaterSource Drinkingwatersource { get; set; }
        public SanitationFacilityAccess Sanitationfacilityaccess { get; set; }
        public HIVAIDSAdultPrevalenceRate HIVAIDSadultprevalencerate { get; set; }
        public HIVAIDSPeopleLivingWithHIVAIDS HIVAIDSpeoplelivingwithHIVAIDS { get; set; }
        public HIVAIDSDeaths HIVAIDSdeaths { get; set; }
        public ObesityAdultPrevalenceRate Obesityadultprevalencerate { get; set; }
        public ChildrenUnderTheAgeOf5YearsUnderweight Childrenundertheageof5yearsunderweight { get; set; }
        public EducationExpenditures Educationexpenditures { get; set; }
        public Literacy Literacy { get; set; }
        public SchoolLifeExpectancyPrimaryToTertiaryEducation Schoollifeexpectancyprimarytotertiaryeducation { get; set; }
        public ChildLaborChildrenAges514 Childlaborchildrenages514 { get; set; }
        public UnemploymentYouthAges1524 Unemploymentyouthages1524 { get; set; }
    }

    public class Population
    {
        public string text { get; set; }
    }

    public class Nationality
    {
        public Noun noun { get; set; }
        public Adjective adjective { get; set; }
    }

    public class Noun
    {
        public string text { get; set; }
    }

    public class Adjective
    {
        public string text { get; set; }
    }

    public class EthnicGroups
    {
        public string text { get; set; }
        public Note note { get; set; }
    }

    public class Note
    {
        public string text { get; set; }
    }

    public class Languages
    {
        public string text { get; set; }
    }

    public class Religions
    {
        public string text { get; set; }
    }

    public class DemographicProfile
    {
        public string text { get; set; }
    }

    public class AgeStructure
    {
        public _014Years _014years { get; set; }
        public _1524Years _1524years { get; set; }
        public _2554Years _2554years { get; set; }
        public _5564Years _5564years { get; set; }
        public _65YearsAndOver _65yearsandover { get; set; }
    }

    public class _014Years
    {
        public string text { get; set; }
    }

    public class _1524Years
    {
        public string text { get; set; }
    }

    public class _2554Years
    {
        public string text { get; set; }
    }

    public class _5564Years
    {
        public string text { get; set; }
    }

    public class _65YearsAndOver
    {
        public string text { get; set; }
    }

    public class DependencyRatios
    {
        public TotalDependencyRatio totaldependencyratio { get; set; }
        public YouthDependencyRatio youthdependencyratio { get; set; }
        public ElderlyDependencyRatio elderlydependencyratio { get; set; }
        public PotentialSupportRatio potentialsupportratio { get; set; }
    }

    public class TotalDependencyRatio
    {
        public string text { get; set; }
    }

    public class YouthDependencyRatio
    {
        public string text { get; set; }
    }

    public class ElderlyDependencyRatio
    {
        public string text { get; set; }
    }

    public class PotentialSupportRatio
    {
        public string text { get; set; }
    }

    public class MedianAge
    {
        public Total2 total { get; set; }
        public Male male { get; set; }
        public Female female { get; set; }
    }

    public class Total2
    {
        public string text { get; set; }
    }

    public class Male
    {
        public string text { get; set; }
    }

    public class Female
    {
        public string text { get; set; }
    }

    public class PopulationGrowthRate
    {
        public string text { get; set; }
    }

    public class BirthRate
    {
        public string text { get; set; }
    }

    public class DeathRate
    {
        public string text { get; set; }
    }

    public class NetMigrationRate
    {
        public string text { get; set; }
    }

    public class Urbanization
    {
        public UrbanPopulation urbanpopulation { get; set; }
        public RateOfUrbanization rateofurbanization { get; set; }
    }

    public class UrbanPopulation
    {
        public string text { get; set; }
    }

    public class RateOfUrbanization
    {
        public string text { get; set; }
    }

    public class MajorUrbanAreasPopulation
    {
        public string text { get; set; }
    }

    public class SexRatio
    {
        public AtBirth atbirth { get; set; }
        public _014Years1 _014years { get; set; }
        public _1524Years1 _1524years { get; set; }
        public _2554Years1 _2554years { get; set; }
        public _5564Years1 _5564years { get; set; }
        public _65YearsAndOver1 _65yearsandover { get; set; }
        public TotalPopulation totalpopulation { get; set; }
    }

    public class AtBirth
    {
        public string text { get; set; }
    }

    public class _014Years1
    {
        public string text { get; set; }
    }

    public class _1524Years1
    {
        public string text { get; set; }
    }

    public class _2554Years1
    {
        public string text { get; set; }
    }

    public class _5564Years1
    {
        public string text { get; set; }
    }

    public class _65YearsAndOver1
    {
        public string text { get; set; }
    }

    public class TotalPopulation
    {
        public string text { get; set; }
    }

    public class MaternalMortalityRate
    {
        public string text { get; set; }
    }

    public class InfantMortalityRate
    {
        public Total3 total { get; set; }
        public Male1 male { get; set; }
        public Female1 female { get; set; }
    }

    public class Total3
    {
        public string text { get; set; }
    }

    public class Male1
    {
        public string text { get; set; }
    }

    public class Female1
    {
        public string text { get; set; }
    }

    public class LifeExpectancyAtBirth
    {
        public TotalPopulation1 totalpopulation { get; set; }
        public Male2 male { get; set; }
        public Female2 female { get; set; }
    }

    public class TotalPopulation1
    {
        public string text { get; set; }
    }

    public class Male2
    {
        public string text { get; set; }
    }

    public class Female2
    {
        public string text { get; set; }
    }

    public class TotalFertilityRate
    {
        public string text { get; set; }
    }

    public class ContraceptivePrevalenceRate
    {
        public string text { get; set; }
    }

    public class HealthExpenditures
    {
        public string text { get; set; }
    }

    public class PhysiciansDensity
    {
        public string text { get; set; }
    }

    public class DrinkingWaterSource
    {
        public Improved improved { get; set; }
        public Unimproved unimproved { get; set; }
    }

    public class Improved
    {
        public string text { get; set; }
    }

    public class Unimproved
    {
        public string text { get; set; }
    }

    public class SanitationFacilityAccess
    {
        public Improved1 improved { get; set; }
        public Unimproved1 unimproved { get; set; }
    }

    public class Improved1
    {
        public string text { get; set; }
    }

    public class Unimproved1
    {
        public string text { get; set; }
    }

    public class HIVAIDSAdultPrevalenceRate
    {
        public string text { get; set; }
    }

    public class HIVAIDSPeopleLivingWithHIVAIDS
    {
        public string text { get; set; }
    }

    public class HIVAIDSDeaths
    {
        public string text { get; set; }
    }

    public class ObesityAdultPrevalenceRate
    {
        public string text { get; set; }
    }

    public class ChildrenUnderTheAgeOf5YearsUnderweight
    {
        public string text { get; set; }
    }

    public class EducationExpenditures
    {
        public string text { get; set; }
    }

    public class Literacy
    {
        public Definition definition { get; set; }
        public TotalPopulation2 totalpopulation { get; set; }
        public Male3 male { get; set; }
        public Female3 female { get; set; }
    }

    public class Definition
    {
        public string text { get; set; }
    }

    public class TotalPopulation2
    {
        public string text { get; set; }
    }

    public class Male3
    {
        public string text { get; set; }
    }

    public class Female3
    {
        public string text { get; set; }
    }

    public class SchoolLifeExpectancyPrimaryToTertiaryEducation
    {
        public Total4 total { get; set; }
        public Male4 male { get; set; }
        public Female4 female { get; set; }
    }

    public class Total4
    {
        public string text { get; set; }
    }

    public class Male4
    {
        public string text { get; set; }
    }

    public class Female4
    {
        public string text { get; set; }
    }

    public class ChildLaborChildrenAges514
    {
        public TotalNumber totalnumber { get; set; }
        public Percentage percentage { get; set; }
    }

    public class TotalNumber
    {
        public string text { get; set; }
    }

    public class Percentage
    {
        public string text { get; set; }
    }

    public class UnemploymentYouthAges1524
    {
        public Total5 total { get; set; }
        public Male5 male { get; set; }
        public Female5 female { get; set; }
    }

    public class Total5
    {
        public string text { get; set; }
    }

    public class Male5
    {
        public string text { get; set; }
    }

    public class Female5
    {
        public string text { get; set; }
    }

    public class Government
    {
        public CountryName Countryname { get; set; }
        public GovernmentType Governmenttype { get; set; }
        public Capital Capital { get; set; }
        public AdministrativeDivisions Administrativedivisions { get; set; }
        public Independence Independence { get; set; }
        public NationalHoliday Nationalholiday { get; set; }
        public Constitution Constitution { get; set; }
        public LegalSystem Legalsystem { get; set; }
        public InternationalLawOrganizationParticipation Internationallaworganizationparticipation { get; set; }
        public Citizenship Citizenship { get; set; }
        public Suffrage Suffrage { get; set; }
        public ExecutiveBranch Executivebranch { get; set; }
        public LegislativeBranch Legislativebranch { get; set; }
        public JudicialBranch Judicialbranch { get; set; }
        public PoliticalPartiesAndLeaders Politicalpartiesandleaders { get; set; }
        public PoliticalPressureGroupsAndLeaders Politicalpressuregroupsandleaders { get; set; }
        public InternationalOrganizationParticipation Internationalorganizationparticipation { get; set; }
        public DiplomaticRepresentationInTheUS DiplomaticrepresentationintheUS { get; set; }
        public DiplomaticRepresentationFromTheUS DiplomaticrepresentationfromtheUS { get; set; }
        public FlagDescription Flagdescription { get; set; }
        public NationalSymbolS Nationalsymbols { get; set; }
        public NationalAnthem Nationalanthem { get; set; }
    }

    public class CountryName
    {
        public ConventionalLongForm conventionallongform { get; set; }
        public ConventionalShortForm conventionalshortform { get; set; }
        public LocalLongForm locallongform { get; set; }
        public LocalShortForm localshortform { get; set; }
        public Etymology etymology { get; set; }
    }

    public class ConventionalLongForm
    {
        public string text { get; set; }
    }

    public class ConventionalShortForm
    {
        public string text { get; set; }
    }

    public class LocalLongForm
    {
        public string text { get; set; }
    }

    public class LocalShortForm
    {
        public string text { get; set; }
    }

    public class Etymology
    {
        public string text { get; set; }
    }

    public class GovernmentType
    {
        public string text { get; set; }
    }

    public class Capital
    {
        public Name name { get; set; }
        public GeographicCoordinates1 geographiccoordinates { get; set; }
        public TimeDifference timedifference { get; set; }
    }

    public class Name
    {
        public string text { get; set; }
    }

    public class GeographicCoordinates1
    {
        public string text { get; set; }
    }

    public class TimeDifference
    {
        public string text { get; set; }
    }

    public class AdministrativeDivisions
    {
        public string text { get; set; }
    }

    public class Independence
    {
        public string text { get; set; }
    }

    public class NationalHoliday
    {
        public string text { get; set; }
    }

    public class Constitution
    {
        public string text { get; set; }
    }

    public class LegalSystem
    {
        public string text { get; set; }
    }

    public class InternationalLawOrganizationParticipation
    {
        public string text { get; set; }
    }

    public class Citizenship
    {
        public CitizenshipByBirth citizenshipbybirth { get; set; }
        public CitizenshipByDescentOnly citizenshipbydescentonly { get; set; }
        public DualCitizenshipRecognized dualcitizenshiprecognized { get; set; }
        public ResidencyRequirementForNaturalization residencyrequirementfornaturalization { get; set; }
    }

    public class CitizenshipByBirth
    {
        public string text { get; set; }
    }

    public class CitizenshipByDescentOnly
    {
        public string text { get; set; }
    }

    public class DualCitizenshipRecognized
    {
        public string text { get; set; }
    }

    public class ResidencyRequirementForNaturalization
    {
        public string text { get; set; }
    }

    public class Suffrage
    {
        public string text { get; set; }
    }

    public class ExecutiveBranch
    {
        public ChiefOfState chiefofstate { get; set; }
        public HeadOfGovernment headofgovernment { get; set; }
        public Cabinet cabinet { get; set; }
        public ElectionsAppointments electionsappointments { get; set; }
        public ElectionResults electionresults { get; set; }
    }

    public class ChiefOfState
    {
        public string text { get; set; }
    }

    public class HeadOfGovernment
    {
        public string text { get; set; }
    }

    public class Cabinet
    {
        public string text { get; set; }
    }

    public class ElectionsAppointments
    {
        public string text { get; set; }
    }

    public class ElectionResults
    {
        public string text { get; set; }
    }

    public class LegislativeBranch
    {
        public Description description { get; set; }
        public Elections elections { get; set; }
        public ElectionResults1 electionresults { get; set; }
    }

    public class Description
    {
        public string text { get; set; }
    }

    public class Elections
    {
        public string text { get; set; }
    }

    public class ElectionResults1
    {
        public string text { get; set; }
    }

    public class JudicialBranch
    {
        public HighestCourtS highestcourts { get; set; }
        public JudgeSelectionAndTermOfOffice judgeselectionandtermofoffice { get; set; }
        public SubordinateCourts subordinatecourts { get; set; }
    }

    public class HighestCourtS
    {
        public string text { get; set; }
    }

    public class JudgeSelectionAndTermOfOffice
    {
        public string text { get; set; }
    }

    public class SubordinateCourts
    {
        public string text { get; set; }
    }

    public class PoliticalPartiesAndLeaders
    {
        public string text { get; set; }
        public Note1 note { get; set; }
    }

    public class Note1
    {
        public string text { get; set; }
    }

    public class PoliticalPressureGroupsAndLeaders
    {
        public string text { get; set; }
    }

    public class InternationalOrganizationParticipation
    {
        public string text { get; set; }
    }

    public class DiplomaticRepresentationInTheUS
    {
        public ChiefOfMission chiefofmission { get; set; }
        public Chancery chancery { get; set; }
        public Telephone telephone { get; set; }
        public FAX FAX { get; set; }
        public ConsulateSGeneral consulatesgeneral { get; set; }
    }

    public class ChiefOfMission
    {
        public string text { get; set; }
    }

    public class Chancery
    {
        public string text { get; set; }
    }

    public class Telephone
    {
        public string text { get; set; }
    }

    public class FAX
    {
        public string text { get; set; }
    }

    public class ConsulateSGeneral
    {
        public string text { get; set; }
    }

    public class DiplomaticRepresentationFromTheUS
    {
        public ChiefOfMission1 chiefofmission { get; set; }
        public Embassy embassy { get; set; }
        public MailingAddress mailingaddress { get; set; }
        public Telephone1 telephone { get; set; }
        public FAX1 FAX { get; set; }
    }

    public class ChiefOfMission1
    {
        public string text { get; set; }
    }

    public class Embassy
    {
        public string text { get; set; }
    }

    public class MailingAddress
    {
        public string text { get; set; }
    }

    public class Telephone1
    {
        public string text { get; set; }
    }

    public class FAX1
    {
        public string text { get; set; }
    }

    public class FlagDescription
    {
        public string text { get; set; }
    }

    public class NationalSymbolS
    {
        public string text { get; set; }
    }

    public class NationalAnthem
    {
        public Name1 name { get; set; }
        public LyricsMusic lyricsmusic { get; set; }
        public Note2 note { get; set; }
    }

    public class Name1
    {
        public string text { get; set; }
    }

    public class LyricsMusic
    {
        public string text { get; set; }
    }

    public class Note2
    {
        public string text { get; set; }
    }

    public class Economy
    {
        public EconomyOverview Economyoverview { get; set; }
        public GDPPurchasingPowerParity GDPpurchasingpowerparity { get; set; }
        public GDPOfficialExchangeRate GDPofficialexchangerate { get; set; }
        public GDPRealGrowthRate GDPrealgrowthrate { get; set; }
        public GDPPerCapitaPPP GDPpercapitaPPP { get; set; }
        public GrossNationalSaving Grossnationalsaving { get; set; }
        public GDPCompositionByEndUse GDPcompositionbyenduse { get; set; }
        public GDPCompositionBySectorOfOrigin GDPcompositionbysectoroforigin { get; set; }
        public AgricultureProducts Agricultureproducts { get; set; }
        public Industries Industries { get; set; }
        public IndustrialProductionGrowthRate Industrialproductiongrowthrate { get; set; }
        public LaborForce Laborforce { get; set; }
        public LaborForceByOccupation Laborforcebyoccupation { get; set; }
        public UnemploymentRate Unemploymentrate { get; set; }
        public PopulationBelowPovertyLine Populationbelowpovertyline { get; set; }
        public HouseholdIncomeOrConsumptionByPercentageShare Householdincomeorconsumptionbypercentageshare { get; set; }
        public DistributionOfFamilyIncomeGiniIndex DistributionoffamilyincomeGiniindex { get; set; }
        public Budget Budget { get; set; }
        public TaxesAndOtherRevenues Taxesandotherrevenues { get; set; }
        public BudgetSurplusOrDeficit Budgetsurplusordeficit { get; set; }
        public PublicDebt Publicdebt { get; set; }
        public FiscalYear Fiscalyear { get; set; }
        public InflationRateConsumerPrices Inflationrateconsumerprices { get; set; }
        public CentralBankDiscountRate Centralbankdiscountrate { get; set; }
        public CommercialBankPrimeLendingRate Commercialbankprimelendingrate { get; set; }
        public StockOfNarrowMoney Stockofnarrowmoney { get; set; }
        public StockOfBroadMoney Stockofbroadmoney { get; set; }
        public StockOfDomesticCredit Stockofdomesticcredit { get; set; }
        public MarketValueOfPubliclyTradedShares Marketvalueofpubliclytradedshares { get; set; }
        public CurrentAccountBalance Currentaccountbalance { get; set; }
        public Exports Exports { get; set; }
        public ExportsCommodities Exportscommodities { get; set; }
        public ExportsPartners Exportspartners { get; set; }
        public Imports Imports { get; set; }
        public ImportsCommodities Importscommodities { get; set; }
        public ImportsPartners Importspartners { get; set; }
        public ReservesOfForeignExchangeAndGold Reservesofforeignexchangeandgold { get; set; }
        public DebtExternal Debtexternal { get; set; }
        public StockOfDirectForeignInvestmentAtHome Stockofdirectforeigninvestmentathome { get; set; }
        public StockOfDirectForeignInvestmentAbroad Stockofdirectforeigninvestmentabroad { get; set; }
        public ExchangeRates Exchangerates { get; set; }
    }

    public class EconomyOverview
    {
        public string text { get; set; }
    }

    public class GDPPurchasingPowerParity
    {
        public string text { get; set; }
        public Note3 note { get; set; }
    }

    public class Note3
    {
        public string text { get; set; }
    }

    public class GDPOfficialExchangeRate
    {
        public string text { get; set; }
    }

    public class GDPRealGrowthRate
    {
        public string text { get; set; }
    }

    public class GDPPerCapitaPPP
    {
        public string text { get; set; }
        public Note4 note { get; set; }
    }

    public class Note4
    {
        public string text { get; set; }
    }

    public class GrossNationalSaving
    {
        public string text { get; set; }
    }

    public class GDPCompositionByEndUse
    {
        public HouseholdConsumption householdconsumption { get; set; }
        public GovernmentConsumption governmentconsumption { get; set; }
        public InvestmentInFixedCapital investmentinfixedcapital { get; set; }
        public InvestmentInInventories investmentininventories { get; set; }
        public ExportsOfGoodsAndServices exportsofgoodsandservices { get; set; }
        public ImportsOfGoodsAndServices importsofgoodsandservices { get; set; }
    }

    public class HouseholdConsumption
    {
        public string text { get; set; }
    }

    public class GovernmentConsumption
    {
        public string text { get; set; }
    }

    public class InvestmentInFixedCapital
    {
        public string text { get; set; }
    }

    public class InvestmentInInventories
    {
        public string text { get; set; }
    }

    public class ExportsOfGoodsAndServices
    {
        public string text { get; set; }
    }

    public class ImportsOfGoodsAndServices
    {
        public string text { get; set; }
    }

    public class GDPCompositionBySectorOfOrigin
    {
        public Agriculture agriculture { get; set; }
        public Industry industry { get; set; }
        public Services services { get; set; }
    }

    public class Agriculture
    {
        public string text { get; set; }
    }

    public class Industry
    {
        public string text { get; set; }
    }

    public class Services
    {
        public string text { get; set; }
    }

    public class AgricultureProducts
    {
        public string text { get; set; }
    }

    public class Industries
    {
        public string text { get; set; }
    }

    public class IndustrialProductionGrowthRate
    {
        public string text { get; set; }
    }

    public class LaborForce
    {
        public string text { get; set; }
    }

    public class LaborForceByOccupation
    {
        public Agriculture1 agriculture { get; set; }
        public Industry1 industry { get; set; }
        public Services1 services { get; set; }
    }

    public class Agriculture1
    {
        public string text { get; set; }
    }

    public class Industry1
    {
        public string text { get; set; }
    }

    public class Services1
    {
        public string text { get; set; }
    }

    public class UnemploymentRate
    {
        public string text { get; set; }
    }

    public class PopulationBelowPovertyLine
    {
        public string text { get; set; }
    }

    public class HouseholdIncomeOrConsumptionByPercentageShare
    {
        public Lowest10 lowest10 { get; set; }
        public Highest10 highest10 { get; set; }
    }

    public class Lowest10
    {
        public string text { get; set; }
    }

    public class Highest10
    {
        public string text { get; set; }
    }

    public class DistributionOfFamilyIncomeGiniIndex
    {
        public string text { get; set; }
    }

    public class Budget
    {
        public Revenues revenues { get; set; }
        public Expenditures expenditures { get; set; }
    }

    public class Revenues
    {
        public string text { get; set; }
    }

    public class Expenditures
    {
        public string text { get; set; }
    }

    public class TaxesAndOtherRevenues
    {
        public string text { get; set; }
    }

    public class BudgetSurplusOrDeficit
    {
        public string text { get; set; }
    }

    public class PublicDebt
    {
        public string text { get; set; }
        public Note5 note { get; set; }
    }

    public class Note5
    {
        public string text { get; set; }
    }

    public class FiscalYear
    {
        public string text { get; set; }
    }

    public class InflationRateConsumerPrices
    {
        public string text { get; set; }
    }

    public class CentralBankDiscountRate
    {
        public string text { get; set; }
    }

    public class CommercialBankPrimeLendingRate
    {
        public string text { get; set; }
    }

    public class StockOfNarrowMoney
    {
        public string text { get; set; }
    }

    public class StockOfBroadMoney
    {
        public string text { get; set; }
    }

    public class StockOfDomesticCredit
    {
        public string text { get; set; }
    }

    public class MarketValueOfPubliclyTradedShares
    {
        public string text { get; set; }
    }

    public class CurrentAccountBalance
    {
        public string text { get; set; }
    }

    public class Exports
    {
        public string text { get; set; }
    }

    public class ExportsCommodities
    {
        public string text { get; set; }
    }

    public class ExportsPartners
    {
        public string text { get; set; }
    }

    public class Imports
    {
        public string text { get; set; }
    }

    public class ImportsCommodities
    {
        public string text { get; set; }
    }

    public class ImportsPartners
    {
        public string text { get; set; }
    }

    public class ReservesOfForeignExchangeAndGold
    {
        public string text { get; set; }
    }

    public class DebtExternal
    {
        public string text { get; set; }
    }

    public class StockOfDirectForeignInvestmentAtHome
    {
        public string text { get; set; }
    }

    public class StockOfDirectForeignInvestmentAbroad
    {
        public string text { get; set; }
    }

    public class ExchangeRates
    {
        public string text { get; set; }
    }

    public class Energy
    {
        public ElectricityProduction Electricityproduction { get; set; }
        public ElectricityConsumption Electricityconsumption { get; set; }
        public ElectricityExports Electricityexports { get; set; }
        public ElectricityImports Electricityimports { get; set; }
        public ElectricityInstalledGeneratingCapacity Electricityinstalledgeneratingcapacity { get; set; }
        public ElectricityFromFossilFuels Electricityfromfossilfuels { get; set; }
        public ElectricityFromNuclearFuels Electricityfromnuclearfuels { get; set; }
        public ElectricityFromHydroelectricPlants Electricityfromhydroelectricplants { get; set; }
        public ElectricityFromOtherRenewableSources Electricityfromotherrenewablesources { get; set; }
        public CrudeOilProduction Crudeoilproduction { get; set; }
        public CrudeOilExports Crudeoilexports { get; set; }
        public CrudeOilImports Crudeoilimports { get; set; }
        public CrudeOilProvedReserves Crudeoilprovedreserves { get; set; }
        public RefinedPetroleumProductsProduction Refinedpetroleumproductsproduction { get; set; }
        public RefinedPetroleumProductsConsumption Refinedpetroleumproductsconsumption { get; set; }
        public RefinedPetroleumProductsExports Refinedpetroleumproductsexports { get; set; }
        public RefinedPetroleumProductsImports Refinedpetroleumproductsimports { get; set; }
        public NaturalGasProduction Naturalgasproduction { get; set; }
        public NaturalGasConsumption Naturalgasconsumption { get; set; }
        public NaturalGasExports Naturalgasexports { get; set; }
        public NaturalGasImports Naturalgasimports { get; set; }
        public NaturalGasProvedReserves Naturalgasprovedreserves { get; set; }
        public CarbonDioxideEmissionsFromConsumptionOfEnergy Carbondioxideemissionsfromconsumptionofenergy { get; set; }
    }

    public class ElectricityProduction
    {
        public string text { get; set; }
    }

    public class ElectricityConsumption
    {
        public string text { get; set; }
    }

    public class ElectricityExports
    {
        public string text { get; set; }
    }

    public class ElectricityImports
    {
        public string text { get; set; }
    }

    public class ElectricityInstalledGeneratingCapacity
    {
        public string text { get; set; }
    }

    public class ElectricityFromFossilFuels
    {
        public string text { get; set; }
    }

    public class ElectricityFromNuclearFuels
    {
        public string text { get; set; }
    }

    public class ElectricityFromHydroelectricPlants
    {
        public string text { get; set; }
    }

    public class ElectricityFromOtherRenewableSources
    {
        public string text { get; set; }
    }

    public class CrudeOilProduction
    {
        public string text { get; set; }
    }

    public class CrudeOilExports
    {
        public string text { get; set; }
    }

    public class CrudeOilImports
    {
        public string text { get; set; }
    }

    public class CrudeOilProvedReserves
    {
        public string text { get; set; }
    }

    public class RefinedPetroleumProductsProduction
    {
        public string text { get; set; }
    }

    public class RefinedPetroleumProductsConsumption
    {
        public string text { get; set; }
    }

    public class RefinedPetroleumProductsExports
    {
        public string text { get; set; }
    }

    public class RefinedPetroleumProductsImports
    {
        public string text { get; set; }
    }

    public class NaturalGasProduction
    {
        public string text { get; set; }
    }

    public class NaturalGasConsumption
    {
        public string text { get; set; }
    }

    public class NaturalGasExports
    {
        public string text { get; set; }
    }

    public class NaturalGasImports
    {
        public string text { get; set; }
    }

    public class NaturalGasProvedReserves
    {
        public string text { get; set; }
    }

    public class CarbonDioxideEmissionsFromConsumptionOfEnergy
    {
        public string text { get; set; }
    }

    public class Communications
    {
        public TelephonesFixedLines Telephonesfixedlines { get; set; }
        public TelephonesMobileCellular Telephonesmobilecellular { get; set; }
        public TelephoneSystem Telephonesystem { get; set; }
        public BroadcastMedia Broadcastmedia { get; set; }
        public InternetCountryCode Internetcountrycode { get; set; }
        public InternetUsers Internetusers { get; set; }
    }

    public class TelephonesFixedLines
    {
        public TotalSubscriptions totalsubscriptions { get; set; }
        public SubscriptionsPer100Inhabitants subscriptionsper100inhabitants { get; set; }
    }

    public class TotalSubscriptions
    {
        public string text { get; set; }
    }

    public class SubscriptionsPer100Inhabitants
    {
        public string text { get; set; }
    }

    public class TelephonesMobileCellular
    {
        public Total6 total { get; set; }
        public SubscriptionsPer100Inhabitants1 subscriptionsper100inhabitants { get; set; }
    }

    public class Total6
    {
        public string text { get; set; }
    }

    public class SubscriptionsPer100Inhabitants1
    {
        public string text { get; set; }
    }

    public class TelephoneSystem
    {
        public GeneralAssessment generalassessment { get; set; }
        public Domestic domestic { get; set; }
        public International international { get; set; }
    }

    public class GeneralAssessment
    {
        public string text { get; set; }
    }

    public class Domestic
    {
        public string text { get; set; }
    }

    public class International
    {
        public string text { get; set; }
    }

    public class BroadcastMedia
    {
        public string text { get; set; }
    }

    public class InternetCountryCode
    {
        public string text { get; set; }
    }

    public class InternetUsers
    {
        public Total7 total { get; set; }
        public PercentOfPopulation percentofpopulation { get; set; }
    }

    public class Total7
    {
        public string text { get; set; }
    }

    public class PercentOfPopulation
    {
        public string text { get; set; }
    }

    public class Transportation
    {
        public NationalAirTransportSystem Nationalairtransportsystem { get; set; }
        public CivilAircraftRegistrationCountryCodePrefix Civilaircraftregistrationcountrycodeprefix { get; set; }
        public Airports Airports { get; set; }
        public AirportsWithPavedRunways Airportswithpavedrunways { get; set; }
        public AirportsWithUnpavedRunways Airportswithunpavedrunways { get; set; }
        public Heliports Heliports { get; set; }
        public Pipelines Pipelines { get; set; }
        public Railways Railways { get; set; }
        public Roadways Roadways { get; set; }
        public MerchantMarine Merchantmarine { get; set; }
        public PortsAndTerminals Portsandterminals { get; set; }
    }

    public class NationalAirTransportSystem
    {
        public NumberOfRegisteredAirCarriers numberofregisteredaircarriers { get; set; }
        public InventoryOfRegisteredAircraftOperatedByAirCarriers inventoryofregisteredaircraftoperatedbyaircarriers { get; set; }
        public AnnualPassengerTrafficOnRegisteredAirCarriers annualpassengertrafficonregisteredaircarriers { get; set; }
        public AnnualFreightTrafficOnRegisteredAirCarriers annualfreighttrafficonregisteredaircarriers { get; set; }
    }

    public class NumberOfRegisteredAirCarriers
    {
        public string text { get; set; }
    }

    public class InventoryOfRegisteredAircraftOperatedByAirCarriers
    {
        public string text { get; set; }
    }

    public class AnnualPassengerTrafficOnRegisteredAirCarriers
    {
        public string text { get; set; }
    }

    public class AnnualFreightTrafficOnRegisteredAirCarriers
    {
        public string text { get; set; }
    }

    public class CivilAircraftRegistrationCountryCodePrefix
    {
        public string text { get; set; }
    }

    public class Airports
    {
        public string text { get; set; }
    }

    public class AirportsWithPavedRunways
    {
        public Total8 total { get; set; }
        public Over3047M over3047m { get; set; }
        public _2438To3047M _2438to3047m { get; set; }
        public _1524To2437M _1524to2437m { get; set; }
        public _914To1523M _914to1523m { get; set; }
        public Under914M under914m { get; set; }
    }

    public class Total8
    {
        public string text { get; set; }
    }

    public class Over3047M
    {
        public string text { get; set; }
    }

    public class _2438To3047M
    {
        public string text { get; set; }
    }

    public class _1524To2437M
    {
        public string text { get; set; }
    }

    public class _914To1523M
    {
        public string text { get; set; }
    }

    public class Under914M
    {
        public string text { get; set; }
    }

    public class AirportsWithUnpavedRunways
    {
        public Total9 total { get; set; }
        public _2438To3047M1 _2438to3047m { get; set; }
        public _1524To2437M1 _1524to2437m { get; set; }
        public _914To1523M1 _914to1523m { get; set; }
        public Under914M1 under914m { get; set; }
    }

    public class Total9
    {
        public string text { get; set; }
    }

    public class _2438To3047M1
    {
        public string text { get; set; }
    }

    public class _1524To2437M1
    {
        public string text { get; set; }
    }

    public class _914To1523M1
    {
        public string text { get; set; }
    }

    public class Under914M1
    {
        public string text { get; set; }
    }

    public class Heliports
    {
        public string text { get; set; }
    }

    public class Pipelines
    {
        public string text { get; set; }
    }

    public class Railways
    {
        public Total10 total { get; set; }
        public StandardGauge standardgauge { get; set; }
        public NarrowGauge narrowgauge { get; set; }
    }

    public class Total10
    {
        public string text { get; set; }
    }

    public class StandardGauge
    {
        public string text { get; set; }
    }

    public class NarrowGauge
    {
        public string text { get; set; }
    }

    public class Roadways
    {
        public Total11 total { get; set; }
        public Paved paved { get; set; }
        public Unpaved unpaved { get; set; }
    }

    public class Total11
    {
        public string text { get; set; }
    }

    public class Paved
    {
        public string text { get; set; }
    }

    public class Unpaved
    {
        public string text { get; set; }
    }

    public class MerchantMarine
    {
        public Total12 total { get; set; }
        public ByType bytype { get; set; }
        public ForeignOwned foreignowned { get; set; }
    }

    public class Total12
    {
        public string text { get; set; }
    }

    public class ByType
    {
        public string text { get; set; }
    }

    public class ForeignOwned
    {
        public string text { get; set; }
    }

    public class PortsAndTerminals
    {
        public MajorSeaportS majorseaports { get; set; }
        public LNGTerminalSExport LNGterminalsexport { get; set; }
    }

    public class MajorSeaportS
    {
        public string text { get; set; }
    }

    public class LNGTerminalSExport
    {
        public string text { get; set; }
    }

    public class MilitaryAndSecurity
    {
        public MilitaryBranches Militarybranches { get; set; }
        public MilitaryServiceAgeAndObligation Militaryserviceageandobligation { get; set; }
        public MilitaryExpenditures Militaryexpenditures { get; set; }
    }

    public class MilitaryBranches
    {
        public string text { get; set; }
    }

    public class MilitaryServiceAgeAndObligation
    {
        public string text { get; set; }
    }

    public class MilitaryExpenditures
    {
        public string text { get; set; }
    }

    public class TransnationalIssues
    {
        public DisputesInternational Disputesinternational { get; set; }
        public RefugeesAndInternallyDisplacedPersons Refugeesandinternallydisplacedpersons { get; set; }
        public TraffickingInPersons Traffickinginpersons { get; set; }
    }

    public class DisputesInternational
    {
        public string text { get; set; }
    }

    public class RefugeesAndInternallyDisplacedPersons
    {
        public RefugeesCountryOfOrigin refugeescountryoforigin { get; set; }
        public Idps IDPs { get; set; }
    }

    public class RefugeesCountryOfOrigin
    {
        public string text { get; set; }
    }

    public class Idps
    {
        public string text { get; set; }
    }

    public class TraffickingInPersons
    {
        public CurrentSituation currentsituation { get; set; }
        public TierRating tierrating { get; set; }
    }

    public class CurrentSituation
    {
        public string text { get; set; }
    }

    public class TierRating
    {
        public string text { get; set; }
    }

}

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ConsoleApp_eftest
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<BASE_AREA> BASE_AREA { get; set; }
        public virtual DbSet<BASE_BARCODE_PRINT_INSTRUCTION> BASE_BARCODE_PRINT_INSTRUCTION { get; set; }
        public virtual DbSet<BASE_COMMON_SELECT_MAIN> BASE_COMMON_SELECT_MAIN { get; set; }
        public virtual DbSet<BASE_EMAIL_PLACEHOLDER> BASE_EMAIL_PLACEHOLDER { get; set; }
        public virtual DbSet<BASE_EMAIL_SMTP> BASE_EMAIL_SMTP { get; set; }
        public virtual DbSet<BASE_EMAIL_TEMPLATE> BASE_EMAIL_TEMPLATE { get; set; }
        public virtual DbSet<BASE_ORG_TYPE> BASE_ORG_TYPE { get; set; }
        public virtual DbSet<BASE_PAYMENT_PLAN> BASE_PAYMENT_PLAN { get; set; }
        public virtual DbSet<BASE_SALES_PRODUCT_TYPE> BASE_SALES_PRODUCT_TYPE { get; set; }
        public virtual DbSet<BCONTRACTPLANPAYMENTTIME> BCONTRACTPLANPAYMENTTIME { get; set; }
        public virtual DbSet<BIP_RECEIVE> BIP_RECEIVE { get; set; }
        public virtual DbSet<BIP_RECEIVE_CHANGE> BIP_RECEIVE_CHANGE { get; set; }
        public virtual DbSet<BIP_RECEIVE_CHANGE_DETAIL> BIP_RECEIVE_CHANGE_DETAIL { get; set; }
        public virtual DbSet<BIP_RECEIVE_CHANGE_SOURCE> BIP_RECEIVE_CHANGE_SOURCE { get; set; }
        public virtual DbSet<BIP_RECEIVE_EVIDENCE> BIP_RECEIVE_EVIDENCE { get; set; }
        public virtual DbSet<BIP_RECEIVE_PRODUCT> BIP_RECEIVE_PRODUCT { get; set; }
        public virtual DbSet<BIP_SUBJECT> BIP_SUBJECT { get; set; }
        public virtual DbSet<CM_COST_OVER> CM_COST_OVER { get; set; }
        public virtual DbSet<CM_INVOICE_PRODUCT> CM_INVOICE_PRODUCT { get; set; }
        public virtual DbSet<CM_MILESTONE_PAYMENT> CM_MILESTONE_PAYMENT { get; set; }
        public virtual DbSet<CM_MILESTONE_PRODUCT> CM_MILESTONE_PRODUCT { get; set; }
        public virtual DbSet<CM_PROJECT_MANAGER> CM_PROJECT_MANAGER { get; set; }
        public virtual DbSet<CM_PROJECT_PROFITS> CM_PROJECT_PROFITS { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT> CM_SALES_CONTRACT { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT_ATTACH> CM_SALES_CONTRACT_ATTACH { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT_ATTACH_OTHER> CM_SALES_CONTRACT_ATTACH_OTHER { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT_CHECK> CM_SALES_CONTRACT_CHECK { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT_CUSTOM_SIGN> CM_SALES_CONTRACT_CUSTOM_SIGN { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT_CUSTOMER> CM_SALES_CONTRACT_CUSTOMER { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT_DOCUMENT> CM_SALES_CONTRACT_DOCUMENT { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT_EXECUTE> CM_SALES_CONTRACT_EXECUTE { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT_EXPENSE> CM_SALES_CONTRACT_EXPENSE { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT_IMPLEMENT> CM_SALES_CONTRACT_IMPLEMENT { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT_INVOICE> CM_SALES_CONTRACT_INVOICE { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT_MILESTONE> CM_SALES_CONTRACT_MILESTONE { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT_PAYMENT> CM_SALES_CONTRACT_PAYMENT { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT_PLAN> CM_SALES_CONTRACT_PLAN { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT_PRODUCT> CM_SALES_CONTRACT_PRODUCT { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT_RELATION> CM_SALES_CONTRACT_RELATION { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT_SIGN_PRODUCT> CM_SALES_CONTRACT_SIGN_PRODUCT { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT_SPEND> CM_SALES_CONTRACT_SPEND { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT_SUBCONTRACT> CM_SALES_CONTRACT_SUBCONTRACT { get; set; }
        public virtual DbSet<CM_SALES_CONTRACT_WRITEOFF> CM_SALES_CONTRACT_WRITEOFF { get; set; }
        public virtual DbSet<CM_SALES_PLAN> CM_SALES_PLAN { get; set; }
        public virtual DbSet<CM_SALES_PLAN_ATTACH> CM_SALES_PLAN_ATTACH { get; set; }
        public virtual DbSet<CM_SALES_PLAN_CUSTOMER> CM_SALES_PLAN_CUSTOMER { get; set; }
        public virtual DbSet<CM_SALES_PLAN_DEVICE> CM_SALES_PLAN_DEVICE { get; set; }
        public virtual DbSet<CM_SALES_PLAN_OTHER> CM_SALES_PLAN_OTHER { get; set; }
        public virtual DbSet<CM_SALES_PLAN_PRODUCT> CM_SALES_PLAN_PRODUCT { get; set; }
        public virtual DbSet<CM_SALES_PLAN_SOFTWARE> CM_SALES_PLAN_SOFTWARE { get; set; }
        public virtual DbSet<CM_SC_CHANGE> CM_SC_CHANGE { get; set; }
        public virtual DbSet<CM_SC_CHANGE_CONTRACT> CM_SC_CHANGE_CONTRACT { get; set; }
        public virtual DbSet<CM_SC_CHANGE_DETAIL> CM_SC_CHANGE_DETAIL { get; set; }
        public virtual DbSet<CM_SC_FINISH> CM_SC_FINISH { get; set; }
        public virtual DbSet<CM_SC_FINISH_DETAIL> CM_SC_FINISH_DETAIL { get; set; }
        public virtual DbSet<CM_SC_PRODUCT_MODULE> CM_SC_PRODUCT_MODULE { get; set; }
        public virtual DbSet<CM_SC_PRODUCT_MODULE_D_ITEM> CM_SC_PRODUCT_MODULE_D_ITEM { get; set; }
        public virtual DbSet<CM_SC_PRODUCT_MODULE_DETAIL> CM_SC_PRODUCT_MODULE_DETAIL { get; set; }
        public virtual DbSet<CM_SP_DEVICE_PARTS_MODEL> CM_SP_DEVICE_PARTS_MODEL { get; set; }
        public virtual DbSet<CM_SP_DEVICE_PARTS_TYPE> CM_SP_DEVICE_PARTS_TYPE { get; set; }
        public virtual DbSet<CM_SP_PRODUCT_MODULE> CM_SP_PRODUCT_MODULE { get; set; }
        public virtual DbSet<CM_SP_PRODUCT_MODULE_D_ITEM> CM_SP_PRODUCT_MODULE_D_ITEM { get; set; }
        public virtual DbSet<CM_SP_PRODUCT_MODULE_DETAIL> CM_SP_PRODUCT_MODULE_DETAIL { get; set; }
        public virtual DbSet<CM_SP_SOFTWARE_MODULE> CM_SP_SOFTWARE_MODULE { get; set; }
        public virtual DbSet<CRM_CONTACT> CRM_CONTACT { get; set; }
        public virtual DbSet<CRM_CUSTOMER> CRM_CUSTOMER { get; set; }
        public virtual DbSet<CRM_SUPPLIER> CRM_SUPPLIER { get; set; }
        public virtual DbSet<CRM_SUPPLIER_ATTACH> CRM_SUPPLIER_ATTACH { get; set; }
        public virtual DbSet<CRM_SUPPLIER_PRODUCT> CRM_SUPPLIER_PRODUCT { get; set; }
        public virtual DbSet<DING_TALK_DEPT> DING_TALK_DEPT { get; set; }
        public virtual DbSet<DING_TALK_TOKEN> DING_TALK_TOKEN { get; set; }
        public virtual DbSet<DING_TALK_USER> DING_TALK_USER { get; set; }
        public virtual DbSet<DM_COMPONENT> DM_COMPONENT { get; set; }
        public virtual DbSet<DM_DEVICE> DM_DEVICE { get; set; }
        public virtual DbSet<DM_HIS_DEVICE> DM_HIS_DEVICE { get; set; }
        public virtual DbSet<DM_HIS_PARTS> DM_HIS_PARTS { get; set; }
        public virtual DbSet<FC_CONTRACTPAYMENTMONTHPLAN> FC_CONTRACTPAYMENTMONTHPLAN { get; set; }
        public virtual DbSet<FC_EXPENSE_POOL> FC_EXPENSE_POOL { get; set; }
        public virtual DbSet<FC_EXPENSE_POOL_PERCENTAGE> FC_EXPENSE_POOL_PERCENTAGE { get; set; }
        public virtual DbSet<FC_RECEIVE_PAYMENT> FC_RECEIVE_PAYMENT { get; set; }
        public virtual DbSet<FC_RECEIVE_PAYMENT_DETAILS> FC_RECEIVE_PAYMENT_DETAILS { get; set; }
        public virtual DbSet<MT_CUSTOMER_SERVICE_ADDRESS> MT_CUSTOMER_SERVICE_ADDRESS { get; set; }
        public virtual DbSet<MT_CUSTOMER_SERVICE_RECORD> MT_CUSTOMER_SERVICE_RECORD { get; set; }
        public virtual DbSet<MT_SEND_REPAIR> MT_SEND_REPAIR { get; set; }
        public virtual DbSet<MT_SEND_REPAIR_ITEM> MT_SEND_REPAIR_ITEM { get; set; }
        public virtual DbSet<OA_CONTRACT> OA_CONTRACT { get; set; }
        public virtual DbSet<OA_CONTRACT_PRODUCT> OA_CONTRACT_PRODUCT { get; set; }
        public virtual DbSet<OA_CUSTOMER> OA_CUSTOMER { get; set; }
        public virtual DbSet<OA_POOL_SALES_CONTRACT> OA_POOL_SALES_CONTRACT { get; set; }
        public virtual DbSet<OA_PROJECT> OA_PROJECT { get; set; }
        public virtual DbSet<OA_PURCHASE> OA_PURCHASE { get; set; }
        public virtual DbSet<OA_PURCHASE_PRODUCT> OA_PURCHASE_PRODUCT { get; set; }
        public virtual DbSet<OA_SALES_CONTRACT_INVOICE> OA_SALES_CONTRACT_INVOICE { get; set; }
        public virtual DbSet<OA_SALES_CONTRACT_RECEIVE> OA_SALES_CONTRACT_RECEIVE { get; set; }
        public virtual DbSet<OA_SUPPLIER> OA_SUPPLIER { get; set; }
        public virtual DbSet<PC_PRODUCE_ATTACH> PC_PRODUCE_ATTACH { get; set; }
        public virtual DbSet<PC_PRODUCE_MESSAGE> PC_PRODUCE_MESSAGE { get; set; }
        public virtual DbSet<PC_PRODUCE_TASK> PC_PRODUCE_TASK { get; set; }
        public virtual DbSet<PC_PRODUCE_TASK_DETAIL> PC_PRODUCE_TASK_DETAIL { get; set; }
        public virtual DbSet<PC_PRODUCE_TASK_EMPLOYEE> PC_PRODUCE_TASK_EMPLOYEE { get; set; }
        public virtual DbSet<PC_PRODUCE_TASK_PRODUCT> PC_PRODUCE_TASK_PRODUCT { get; set; }
        public virtual DbSet<PC_PRODUCE_TASK_QC_DETAIL> PC_PRODUCE_TASK_QC_DETAIL { get; set; }
        public virtual DbSet<PC_PRODUCE_TRACK> PC_PRODUCE_TRACK { get; set; }
        public virtual DbSet<PC_PRODUCE_TRACK_EMPLOYEE> PC_PRODUCE_TRACK_EMPLOYEE { get; set; }
        public virtual DbSet<PC_QC_MODEL> PC_QC_MODEL { get; set; }
        public virtual DbSet<PC_QC_MODEL_STANDARD> PC_QC_MODEL_STANDARD { get; set; }
        public virtual DbSet<PC_QC_STANDARD> PC_QC_STANDARD { get; set; }
        public virtual DbSet<PC_QC_STANDARD_ITEM> PC_QC_STANDARD_ITEM { get; set; }
        public virtual DbSet<PM_BORROW_PARTS> PM_BORROW_PARTS { get; set; }
        public virtual DbSet<PM_BORROW_PARTS_DETAIL> PM_BORROW_PARTS_DETAIL { get; set; }
        public virtual DbSet<PM_COMPONENT_MODEL> PM_COMPONENT_MODEL { get; set; }
        public virtual DbSet<PM_DEVICE_MODEL> PM_DEVICE_MODEL { get; set; }
        public virtual DbSet<PM_DEVICE_MODEL_PARTS_MODEL> PM_DEVICE_MODEL_PARTS_MODEL { get; set; }
        public virtual DbSet<PM_DEVICE_MODEL_PARTS_TYPE> PM_DEVICE_MODEL_PARTS_TYPE { get; set; }
        public virtual DbSet<PM_PARTS_MODEL> PM_PARTS_MODEL { get; set; }
        public virtual DbSet<PM_PARTS_MODEL_COMPONENT> PM_PARTS_MODEL_COMPONENT { get; set; }
        public virtual DbSet<PM_PARTS_TYPE> PM_PARTS_TYPE { get; set; }
        public virtual DbSet<PM_PRODUCT> PM_PRODUCT { get; set; }
        public virtual DbSet<PM_PRODUCT_MODULE> PM_PRODUCT_MODULE { get; set; }
        public virtual DbSet<PM_PRODUCT_MODULE_DETAIL> PM_PRODUCT_MODULE_DETAIL { get; set; }
        public virtual DbSet<PM_PRODUCT_MODULE_DETAIL_ITEM> PM_PRODUCT_MODULE_DETAIL_ITEM { get; set; }
        public virtual DbSet<PM_PRODUCT_MODULE_MUTEX> PM_PRODUCT_MODULE_MUTEX { get; set; }
        public virtual DbSet<PM_PRODUCT_TYPE> PM_PRODUCT_TYPE { get; set; }
        public virtual DbSet<PM_PRODUCT_TYPE_CONFIG> PM_PRODUCT_TYPE_CONFIG { get; set; }
        public virtual DbSet<PM_PRODUCT_TYPE_OLD> PM_PRODUCT_TYPE_OLD { get; set; }
        public virtual DbSet<PM_SIGN_PRODUCT_TYPE> PM_SIGN_PRODUCT_TYPE { get; set; }
        public virtual DbSet<PM_SOFTWARE> PM_SOFTWARE { get; set; }
        public virtual DbSet<PM_SOFTWARE_MODULE> PM_SOFTWARE_MODULE { get; set; }
        public virtual DbSet<PM_TEST_REPORT> PM_TEST_REPORT { get; set; }
        public virtual DbSet<PO_P_C_SIGN_PRODUCT> PO_P_C_SIGN_PRODUCT { get; set; }
        public virtual DbSet<PO_P_C_SIGN_PRODUCT_DETAIL> PO_P_C_SIGN_PRODUCT_DETAIL { get; set; }
        public virtual DbSet<PO_P_O_PRODUCT_PARTS> PO_P_O_PRODUCT_PARTS { get; set; }
        public virtual DbSet<PO_P_O_PRODUCT_PARTS_TYPE> PO_P_O_PRODUCT_PARTS_TYPE { get; set; }
        public virtual DbSet<PO_PURCHASE_APPLY> PO_PURCHASE_APPLY { get; set; }
        public virtual DbSet<PO_PURCHASE_APPLY_ATTACH> PO_PURCHASE_APPLY_ATTACH { get; set; }
        public virtual DbSet<PO_PURCHASE_APPLY_ITEM> PO_PURCHASE_APPLY_ITEM { get; set; }
        public virtual DbSet<PO_PURCHASE_CONTRACT> PO_PURCHASE_CONTRACT { get; set; }
        public virtual DbSet<PO_PURCHASE_CONTRACT_ATTACH> PO_PURCHASE_CONTRACT_ATTACH { get; set; }
        public virtual DbSet<PO_PURCHASE_CONTRACT_INVOICE> PO_PURCHASE_CONTRACT_INVOICE { get; set; }
        public virtual DbSet<PO_PURCHASE_CONTRACT_PAYMENT> PO_PURCHASE_CONTRACT_PAYMENT { get; set; }
        public virtual DbSet<PO_PURCHASE_CONTRACT_PRODUCT> PO_PURCHASE_CONTRACT_PRODUCT { get; set; }
        public virtual DbSet<PO_PURCHASE_CONTRACT_RELATION> PO_PURCHASE_CONTRACT_RELATION { get; set; }
        public virtual DbSet<PO_PURCHASE_EMAIL_LOG> PO_PURCHASE_EMAIL_LOG { get; set; }
        public virtual DbSet<PO_PURCHASE_EMPLOYEE_AREA> PO_PURCHASE_EMPLOYEE_AREA { get; set; }
        public virtual DbSet<PO_PURCHASE_ORDER> PO_PURCHASE_ORDER { get; set; }
        public virtual DbSet<PO_PURCHASE_ORDER_ATTACH> PO_PURCHASE_ORDER_ATTACH { get; set; }
        public virtual DbSet<PO_PURCHASE_ORDER_PARTS> PO_PURCHASE_ORDER_PARTS { get; set; }
        public virtual DbSet<PO_PURCHASE_ORDER_PARTS_PICKED> PO_PURCHASE_ORDER_PARTS_PICKED { get; set; }
        public virtual DbSet<PO_PURCHASE_ORDER_PARTS_TRACK> PO_PURCHASE_ORDER_PARTS_TRACK { get; set; }
        public virtual DbSet<PO_PURCHASE_ORDER_PRODUCT> PO_PURCHASE_ORDER_PRODUCT { get; set; }
        public virtual DbSet<PR_BUSINESS_SPLIT> PR_BUSINESS_SPLIT { get; set; }
        public virtual DbSet<PR_BUSINESS_SPLIT_DETAIL> PR_BUSINESS_SPLIT_DETAIL { get; set; }
        public virtual DbSet<PR_P_F_POOL_IN_OUT> PR_P_F_POOL_IN_OUT { get; set; }
        public virtual DbSet<PR_PROJECT> PR_PROJECT { get; set; }
        public virtual DbSet<PR_PROJECT_AMOUNT_ADJUST> PR_PROJECT_AMOUNT_ADJUST { get; set; }
        public virtual DbSet<PR_PROJECT_ATTACH> PR_PROJECT_ATTACH { get; set; }
        public virtual DbSet<PR_PROJECT_BID> PR_PROJECT_BID { get; set; }
        public virtual DbSet<PR_PROJECT_BONUS> PR_PROJECT_BONUS { get; set; }
        public virtual DbSet<PR_PROJECT_BONUS_DETAIL> PR_PROJECT_BONUS_DETAIL { get; set; }
        public virtual DbSet<PR_PROJECT_BONUS_IMPORT> PR_PROJECT_BONUS_IMPORT { get; set; }
        public virtual DbSet<PR_PROJECT_BUSINESS> PR_PROJECT_BUSINESS { get; set; }
        public virtual DbSet<PR_PROJECT_CONTRACT> PR_PROJECT_CONTRACT { get; set; }
        public virtual DbSet<PR_PROJECT_COST_STRUCT> PR_PROJECT_COST_STRUCT { get; set; }
        public virtual DbSet<PR_PROJECT_COST_TRANSFER> PR_PROJECT_COST_TRANSFER { get; set; }
        public virtual DbSet<PR_PROJECT_DEPLOY_INFO> PR_PROJECT_DEPLOY_INFO { get; set; }
        public virtual DbSet<PR_PROJECT_DEPLOY_TYPE> PR_PROJECT_DEPLOY_TYPE { get; set; }
        public virtual DbSet<PR_PROJECT_FUNDS> PR_PROJECT_FUNDS { get; set; }
        public virtual DbSet<PR_PROJECT_MANAGER_CHANGE> PR_PROJECT_MANAGER_CHANGE { get; set; }
        public virtual DbSet<PR_PROJECT_MILESTONE> PR_PROJECT_MILESTONE { get; set; }
        public virtual DbSet<PR_PROJECT_MILESTONE_PRODUCT> PR_PROJECT_MILESTONE_PRODUCT { get; set; }
        public virtual DbSet<PR_PROJECT_PERCENTAGE> PR_PROJECT_PERCENTAGE { get; set; }
        public virtual DbSet<PR_PROJECT_PRODUCT> PR_PROJECT_PRODUCT { get; set; }
        public virtual DbSet<PR_PROJECT_PROGRESS> PR_PROJECT_PROGRESS { get; set; }
        public virtual DbSet<PR_PROJECT_PROGRESS_TASK> PR_PROJECT_PROGRESS_TASK { get; set; }
        public virtual DbSet<PR_PROJECT_RELEASE> PR_PROJECT_RELEASE { get; set; }
        public virtual DbSet<PR_PROJECT_SPEND> PR_PROJECT_SPEND { get; set; }
        public virtual DbSet<RELATIONSHIP> RELATIONSHIP { get; set; }
        public virtual DbSet<SYS_APP_POWER> SYS_APP_POWER { get; set; }
        public virtual DbSet<SYS_BUSINESS_NOTICE> SYS_BUSINESS_NOTICE { get; set; }
        public virtual DbSet<SYS_COMPANY> SYS_COMPANY { get; set; }
        public virtual DbSet<SYS_COMPANY_CONFIG> SYS_COMPANY_CONFIG { get; set; }
        public virtual DbSet<SYS_COMPANY_CONFIG_PROJECT> SYS_COMPANY_CONFIG_PROJECT { get; set; }
        public virtual DbSet<SYS_CUSTOM_ID> SYS_CUSTOM_ID { get; set; }
        public virtual DbSet<SYS_DATA_POWER> SYS_DATA_POWER { get; set; }
        public virtual DbSet<SYS_DEPARTMENT> SYS_DEPARTMENT { get; set; }
        public virtual DbSet<SYS_EMPLOYEE> SYS_EMPLOYEE { get; set; }
        public virtual DbSet<SYS_EMPLOYEE_CONFIG> SYS_EMPLOYEE_CONFIG { get; set; }
        public virtual DbSet<SYS_EMPLOYEE_DEPARTMENT> SYS_EMPLOYEE_DEPARTMENT { get; set; }
        public virtual DbSet<SYS_EMPLOYEE_ROLE> SYS_EMPLOYEE_ROLE { get; set; }
        public virtual DbSet<SYS_MENU_POWER> SYS_MENU_POWER { get; set; }
        public virtual DbSet<SYS_MILESTONE> SYS_MILESTONE { get; set; }
        public virtual DbSet<SYS_NOTICE> SYS_NOTICE { get; set; }
        public virtual DbSet<SYS_OPERATION_LOG> SYS_OPERATION_LOG { get; set; }
        public virtual DbSet<SYS_PARAMETER> SYS_PARAMETER { get; set; }
        public virtual DbSet<SYS_PARAMETER_ENUM> SYS_PARAMETER_ENUM { get; set; }
        public virtual DbSet<SYS_POSITION> SYS_POSITION { get; set; }
        public virtual DbSet<SYS_ROLE> SYS_ROLE { get; set; }
        public virtual DbSet<SYS_SERIAL_NUMBER> SYS_SERIAL_NUMBER { get; set; }
        public virtual DbSet<SYS_VERSION> SYS_VERSION { get; set; }
        public virtual DbSet<TS_CONSUMABLE_REQUEST> TS_CONSUMABLE_REQUEST { get; set; }
        public virtual DbSet<TS_CONSUMABLE_REQUEST_ITEM> TS_CONSUMABLE_REQUEST_ITEM { get; set; }
        public virtual DbSet<TS_SALES_DELIVERY> TS_SALES_DELIVERY { get; set; }
        public virtual DbSet<TS_SALES_DELIVERY_FEE> TS_SALES_DELIVERY_FEE { get; set; }
        public virtual DbSet<TS_SALES_DELIVERY_ITEM> TS_SALES_DELIVERY_ITEM { get; set; }
        public virtual DbSet<WF_FLOW_EXECUTE> WF_FLOW_EXECUTE { get; set; }
        public virtual DbSet<WF_FLOW_EXECUTE_ATTACH> WF_FLOW_EXECUTE_ATTACH { get; set; }
        public virtual DbSet<WF_FLOW_EXECUTE_EKP> WF_FLOW_EXECUTE_EKP { get; set; }
        public virtual DbSet<WF_FLOW_EXECUTE_EKP_EMPLOYEE> WF_FLOW_EXECUTE_EKP_EMPLOYEE { get; set; }
        public virtual DbSet<WF_FLOW_EXECUTE_EMPLOYEE> WF_FLOW_EXECUTE_EMPLOYEE { get; set; }
        public virtual DbSet<WF_FLOW_EXECUTE_NODE> WF_FLOW_EXECUTE_NODE { get; set; }
        public virtual DbSet<WF_FLOW_EXECUTE_NODE_EKP> WF_FLOW_EXECUTE_NODE_EKP { get; set; }
        public virtual DbSet<WF_FLOW_MODEL> WF_FLOW_MODEL { get; set; }
        public virtual DbSet<WF_FLOW_MODEL_EKP> WF_FLOW_MODEL_EKP { get; set; }
        public virtual DbSet<WF_FLOW_MODEL_NODE> WF_FLOW_MODEL_NODE { get; set; }
        public virtual DbSet<WH_WORKHOURS_DETAILS> WH_WORKHOURS_DETAILS { get; set; }
        public virtual DbSet<WH_WORKHOURS_MAIN> WH_WORKHOURS_MAIN { get; set; }
        public virtual DbSet<WM_STOCK> WM_STOCK { get; set; }
        public virtual DbSet<WM_STOCK_BATCH> WM_STOCK_BATCH { get; set; }
        public virtual DbSet<WM_STOCK_IO> WM_STOCK_IO { get; set; }
        public virtual DbSet<WM_STOCK_IO_APPLY> WM_STOCK_IO_APPLY { get; set; }
        public virtual DbSet<WM_STOCK_IO_BATCH> WM_STOCK_IO_BATCH { get; set; }
        public virtual DbSet<WM_STOCK_IO_ITEM> WM_STOCK_IO_ITEM { get; set; }
        public virtual DbSet<WM_STOCK_ITEM> WM_STOCK_ITEM { get; set; }
        public virtual DbSet<WM_WAREHOUSE> WM_WAREHOUSE { get; set; }
        public virtual DbSet<WM_WAREHOUSE_POSITION> WM_WAREHOUSE_POSITION { get; set; }
        public virtual DbSet<WM_WAREHOUSE_POWER> WM_WAREHOUSE_POWER { get; set; }
        public virtual DbSet<BASE_COMMON_SELECT_ITEM> BASE_COMMON_SELECT_ITEM { get; set; }
        public virtual DbSet<BIZ_REC_WATER> BIZ_REC_WATER { get; set; }
        public virtual DbSet<BIZ_REC_WATER_DETAILS> BIZ_REC_WATER_DETAILS { get; set; }
        public virtual DbSet<BM_BID_WIN> BM_BID_WIN { get; set; }
        public virtual DbSet<CM_AGGREGATE_CONTRACT> CM_AGGREGATE_CONTRACT { get; set; }
        public virtual DbSet<CM_AGGREGATE_CONTRACT_DETAILS> CM_AGGREGATE_CONTRACT_DETAILS { get; set; }
        public virtual DbSet<CM_AGGREGATE_CONTRACT_FINANCE> CM_AGGREGATE_CONTRACT_FINANCE { get; set; }
        public virtual DbSet<CM_AGGREGATE_CONTRACT_INVOICE> CM_AGGREGATE_CONTRACT_INVOICE { get; set; }
        public virtual DbSet<CM_FUNCTIONPOINT_DETAILS> CM_FUNCTIONPOINT_DETAILS { get; set; }
        public virtual DbSet<CM_P_INFO_RELATION> CM_P_INFO_RELATION { get; set; }
        public virtual DbSet<CM_SOFTCHANGE_EVALUATION> CM_SOFTCHANGE_EVALUATION { get; set; }
        public virtual DbSet<CONTRACT_FUNCTIONPOINT> CONTRACT_FUNCTIONPOINT { get; set; }
        public virtual DbSet<CONTRACT_FUNCTIONPOINT_INFO> CONTRACT_FUNCTIONPOINT_INFO { get; set; }
        public virtual DbSet<CRM_CUSTOMER_BANK> CRM_CUSTOMER_BANK { get; set; }
        public virtual DbSet<DM_PARTS> DM_PARTS { get; set; }
        public virtual DbSet<HR_DEPT> HR_DEPT { get; set; }
        public virtual DbSet<LOG_CONTRACTINFO_CHANGE> LOG_CONTRACTINFO_CHANGE { get; set; }
        public virtual DbSet<LOG_CONTRACTINFO_CHANGE_MAIN> LOG_CONTRACTINFO_CHANGE_MAIN { get; set; }
        public virtual DbSet<OA_PROJECT_BILL> OA_PROJECT_BILL { get; set; }
        public virtual DbSet<OA_SALES_CUSTOMER> OA_SALES_CUSTOMER { get; set; }
        public virtual DbSet<PM_PRODUCT_TAG> PM_PRODUCT_TAG { get; set; }
        public virtual DbSet<PO_ICCAERDPURCHASE_APPLY_ITEM> PO_ICCAERDPURCHASE_APPLY_ITEM { get; set; }
        public virtual DbSet<PO_ICCARDPURCHASE_APPLY> PO_ICCARDPURCHASE_APPLY { get; set; }
        public virtual DbSet<PO_PURCHASE_APPLY_IDCAREINFO> PO_PURCHASE_APPLY_IDCAREINFO { get; set; }
        public virtual DbSet<SYS_SERVICES> SYS_SERVICES { get; set; }
        public virtual DbSet<SYS_STATUS_LOG> SYS_STATUS_LOG { get; set; }
        public virtual DbSet<BIZ_REC_WATER_VIEW> BIZ_REC_WATER_VIEW { get; set; }
        public virtual DbSet<CM_PROJECT_PROFITS_VIEW> CM_PROJECT_PROFITS_VIEW { get; set; }
        public virtual DbSet<CONTRACTRECEICEDAMOUNT_VIEW> CONTRACTRECEICEDAMOUNT_VIEW { get; set; }
        public virtual DbSet<NC_SDEPTMENT_COMPANY_RELATION> NC_SDEPTMENT_COMPANY_RELATION { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BASE_AREA>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_AREA>()
                .Property(e => e.PARENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_AREA>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_AREA>()
                .Property(e => e.ZIP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_AREA>()
                .Property(e => e.ALIAS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_AREA>()
                .Property(e => e.AREA_LEVEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_BARCODE_PRINT_INSTRUCTION>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_BARCODE_PRINT_INSTRUCTION>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_BARCODE_PRINT_INSTRUCTION>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_BARCODE_PRINT_INSTRUCTION>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_BARCODE_PRINT_INSTRUCTION>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_BARCODE_PRINT_INSTRUCTION>()
                .Property(e => e.BARCODE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_BARCODE_PRINT_INSTRUCTION>()
                .Property(e => e.BARCODE_SIZE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BARCODE_PRINT_INSTRUCTION>()
                .Property(e => e.INSTRUCTION_TEMPLATE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BARCODE_PRINT_INSTRUCTION>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_BARCODE_PRINT_INSTRUCTION>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMMON_SELECT_MAIN>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_COMMON_SELECT_MAIN>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_COMMON_SELECT_MAIN>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_COMMON_SELECT_MAIN>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_COMMON_SELECT_MAIN>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_COMMON_SELECT_MAIN>()
                .Property(e => e.PID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_COMMON_SELECT_MAIN>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMMON_SELECT_MAIN>()
                .Property(e => e.CODETEXT)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMMON_SELECT_MAIN>()
                .Property(e => e.ITEM_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_COMMON_SELECT_MAIN>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_PLACEHOLDER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_PLACEHOLDER>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_PLACEHOLDER>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_PLACEHOLDER>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_PLACEHOLDER>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_PLACEHOLDER>()
                .Property(e => e.EMAIL_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_PLACEHOLDER>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAIL_PLACEHOLDER>()
                .Property(e => e.CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAIL_PLACEHOLDER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAIL_SMTP>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_SMTP>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_SMTP>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_SMTP>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_SMTP>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_SMTP>()
                .Property(e => e.EMAIL_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAIL_SMTP>()
                .Property(e => e.SERVER_HOST)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAIL_SMTP>()
                .Property(e => e.PORT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_SMTP>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAIL_TEMPLATE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_TEMPLATE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_TEMPLATE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_TEMPLATE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_TEMPLATE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_TEMPLATE>()
                .Property(e => e.EMAIL_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_TEMPLATE>()
                .Property(e => e.TEMPLATE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAIL_TEMPLATE>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAIL_TEMPLATE>()
                .Property(e => e.CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAIL_TEMPLATE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_EMAIL_TEMPLATE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORG_TYPE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_ORG_TYPE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_ORG_TYPE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_ORG_TYPE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_ORG_TYPE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_ORG_TYPE>()
                .Property(e => e.ORG_TYPE_CODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_ORG_TYPE>()
                .Property(e => e.ORG_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORG_TYPE>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_ORG_TYPE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ORG_TYPE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_PAYMENT_PLAN>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_PAYMENT_PLAN>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_PAYMENT_PLAN>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_PAYMENT_PLAN>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_PAYMENT_PLAN>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_PAYMENT_PLAN>()
                .Property(e => e.PLAN_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_PAYMENT_PLAN>()
                .Property(e => e.PLAN_CONDITION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_PAYMENT_PLAN>()
                .Property(e => e.DELAY_DAYS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_PAYMENT_PLAN>()
                .Property(e => e.PERCENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_PAYMENT_PLAN>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_PAYMENT_PLAN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SALES_PRODUCT_TYPE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_SALES_PRODUCT_TYPE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_SALES_PRODUCT_TYPE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_SALES_PRODUCT_TYPE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_SALES_PRODUCT_TYPE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_SALES_PRODUCT_TYPE>()
                .Property(e => e.PRODUCT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_SALES_PRODUCT_TYPE>()
                .Property(e => e.PRODUCT_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SALES_PRODUCT_TYPE>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_SALES_PRODUCT_TYPE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SALES_PRODUCT_TYPE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BCONTRACTPLANPAYMENTTIME>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<BCONTRACTPLANPAYMENTTIME>()
                .Property(e => e.PLANYEAR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BCONTRACTPLANPAYMENTTIME>()
                .Property(e => e.PLANMONTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BCONTRACTPLANPAYMENTTIME>()
                .Property(e => e.AREACODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BCONTRACTPLANPAYMENTTIME>()
                .Property(e => e.PLANWEEKPAYMENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.VERSION)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.BIP_RECEIVE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.RECEIVE_EVIDENCE_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.MIDDLE_DATE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.MIDDLE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.NO_RATE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.DEBT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.REMAIN_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.CUT_RATE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.WAIT_RATE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.NEED_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.LINK_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.MONTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.YEAR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.ERROR_REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_RECEIVE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE>()
                .Property(e => e.EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE>()
                .Property(e => e.EMPLOYEE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE_DETAIL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE_DETAIL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE_DETAIL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE_DETAIL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE_DETAIL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE_DETAIL>()
                .Property(e => e.BIP_RECEIVE_CHANGE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE_DETAIL>()
                .Property(e => e.BIP_RECEIVE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE_SOURCE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE_SOURCE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE_SOURCE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE_SOURCE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE_SOURCE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE_SOURCE>()
                .Property(e => e.BIP_RECEIVE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE_SOURCE>()
                .Property(e => e.BIP_RECEIVE_EVIDENCE_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE_SOURCE>()
                .Property(e => e.RECEIVE_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE_SOURCE>()
                .Property(e => e.RECEIVE_EVIDENCE_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE_SOURCE>()
                .Property(e => e.BIP_RECEIVE_CHANGE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_CHANGE_SOURCE>()
                .Property(e => e.BIP_RECEIVE_PRODUCT_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.MIDDLE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.DATE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.BIP_RECEIVE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.CUSTOMER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.CUSTOMER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.CONTRACT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.BANK_ACOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.DSIGN_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.DSIGN_REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.SUBJECT_CODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.SUBJECT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.DEBIT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.CREDIT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.HELP_COMPUTE)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.HELP_COMPUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.HELP_COMPUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.HELP_COMPUTE4)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.MONTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.SORT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_RECEIVE_EVIDENCE>()
                .Property(e => e.FC_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_PRODUCT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_PRODUCT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_PRODUCT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_PRODUCT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_PRODUCT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_PRODUCT>()
                .Property(e => e.MIDDLE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_PRODUCT>()
                .Property(e => e.BIP_RECEIVE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_PRODUCT>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_PRODUCT>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_PRODUCT>()
                .Property(e => e.FC_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_PRODUCT>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_PRODUCT>()
                .Property(e => e.NO_RATE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_PRODUCT>()
                .Property(e => e.RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_PRODUCT>()
                .Property(e => e.RATE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_PRODUCT>()
                .Property(e => e.BIP_RECEIVE_EVIDENCE_ID_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_PRODUCT>()
                .Property(e => e.BIP_RECEIVE_EVIDENCE_ID_MONTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_PRODUCT>()
                .Property(e => e.BIP_RECEIVE_ID_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_RECEIVE_PRODUCT>()
                .Property(e => e.BIP_RECEIVE_ID_MONTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_SUBJECT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_SUBJECT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_SUBJECT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_SUBJECT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_SUBJECT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_SUBJECT>()
                .Property(e => e.SUBJECT_CODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_SUBJECT>()
                .Property(e => e.SUBJECT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_SUBJECT>()
                .Property(e => e.CONTROL_DIRECTION)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_SUBJECT>()
                .Property(e => e.NUMBER_AMOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_SUBJECT>()
                .Property(e => e.SUBJECT_RANK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIP_SUBJECT>()
                .Property(e => e.END_RANK)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_SUBJECT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_SUBJECT>()
                .Property(e => e.HELP_COMPUTE)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_SUBJECT>()
                .Property(e => e.HELP_COMPUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_SUBJECT>()
                .Property(e => e.HELP_COMPUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<BIP_SUBJECT>()
                .Property(e => e.HELP_COMPUTE4)
                .IsUnicode(false);

            modelBuilder.Entity<CM_COST_OVER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_COST_OVER>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_COST_OVER>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_COST_OVER>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_COST_OVER>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_COST_OVER>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_COST_OVER>()
                .Property(e => e.PURCHASE_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_COST_OVER>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_COST_OVER>()
                .Property(e => e.OVER_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_COST_OVER>()
                .Property(e => e.CUT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_COST_OVER>()
                .Property(e => e.PURCHASE_AMOUNT_NO_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_COST_OVER>()
                .Property(e => e.LINK_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_COST_OVER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_COST_OVER>()
                .Property(e => e.PROJECT_MODEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_COST_OVER>()
                .Property(e => e.CUT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.INVOICE_PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.INVOICE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.INVOICE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.CUSTOMER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.SPECIFICATION)
                .IsUnicode(false);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.SIGN_PRODUCT_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.PERCENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.FC_SIGN_PRODUCT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.SIGN_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.SIGN_PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.NO_RATE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.RATE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.BEFORE_NO_RATE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_INVOICE_PRODUCT>()
                .Property(e => e.BEFORE_RATE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_MILESTONE_PAYMENT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_MILESTONE_PAYMENT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_MILESTONE_PAYMENT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_MILESTONE_PAYMENT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_MILESTONE_PAYMENT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_MILESTONE_PAYMENT>()
                .Property(e => e.CONTRACT_MILESTONE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CM_MILESTONE_PAYMENT>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_MILESTONE_PAYMENT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_MILESTONE_PAYMENT>()
                .Property(e => e.CONFIRM_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_MILESTONE_PAYMENT>()
                .Property(e => e.SALES_CONTRACT_PAYMENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_MILESTONE_PRODUCT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_MILESTONE_PRODUCT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_MILESTONE_PRODUCT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_MILESTONE_PRODUCT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_MILESTONE_PRODUCT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_MILESTONE_PRODUCT>()
                .Property(e => e.CONTRACT_MILESTONE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CM_MILESTONE_PRODUCT>()
                .Property(e => e.SIGN_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_MILESTONE_PRODUCT>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_MILESTONE_PRODUCT>()
                .Property(e => e.PERCENT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_MILESTONE_PRODUCT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_MILESTONE_PRODUCT>()
                .Property(e => e.FINISH_QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_MILESTONE_PRODUCT>()
                .Property(e => e.CONFIRM_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_MANAGER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_MANAGER>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_MANAGER>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_MANAGER>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_MANAGER>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_MANAGER>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_MANAGER>()
                .Property(e => e.PROJECT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_MANAGER>()
                .Property(e => e.PROJECT_AMOUNT_PROFITS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_MANAGER>()
                .Property(e => e.PROJECT_SPEND_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_MANAGER>()
                .Property(e => e.IS_NEW)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_MANAGER>()
                .Property(e => e.COST_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_MANAGER>()
                .Property(e => e.IS_MAIN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_MANAGER>()
                .Property(e => e.PROJECT_ACTUAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_MANAGER>()
                .Property(e => e.YEAR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_MANAGER>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_MANAGER>()
                .Property(e => e.CREATE_PROJECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_MANAGER>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_MANAGER>()
                .Property(e => e.PROJECT_BONUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_MANAGER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.CONTRACTAMOUNT)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.PURCHASE_IN)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.PURCHASE_OUT)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.OCCUPANCY_COST)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.IMPLEMENTATION_LIMIT)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.IMPLEMENTATION)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.IMPLEMENTATIONM)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.DEVELOPMENT)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.DEVELOPMENTM)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.BUSINESS_LIMIT)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.BUSINESS)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.FREE_MAINTENANCE)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.BIDDING_SERVICE_FEE)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.OTHER_COSTS)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.PROFIT_TOTAL)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.PROFIT_RATE)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS>()
                .Property(e => e.CONTRACTAMOUNT_NOTAX)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.CONTRACT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.SALES_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.IS_ALL_ORDERED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.COMPLETION_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.CONTRACT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.SALES_MODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.PARENT_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.BELONG_YEAR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.SOURCE_SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.SUBCONTRACT_SOURCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.IS_FORMAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.PROVINCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.CITY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.DISTRICT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.DISCOUNT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.CONVERSION_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.BE_CONVERSION_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.EXPENSE_POOL_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.BUSINESS_TYPE2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.IS_INNERCONTRACT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.BELONG_PLATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.SALES_PLAN_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.CONTRACT_NO_BPM)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.CONTRACT_MECHANISM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.ISTENDER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.WINNINGBIDARCHIVE)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.BUSINESS_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.FINISH_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.CONTRACT_NO_BPM2)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.IS_PUBLIC_PROJECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.CREATE_COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.PROJECT_MANAGER_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.SUBCONTRACT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.ISPACKAGING)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.REMARK2)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.WORKFLOWNUM)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.ISCONSULTING)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.MAINTENANCE_END_DATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.SOURCE)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.DEPARTMENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.SALES_HELP_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.SOURCE_CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.TEAMWORK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.WORK_AREA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.BUSINESS_ALONG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.PROJECT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.PROJECT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.IMPLEMENT_EMPLOYEE_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.IMPLEMENT_EMPLOYEE_NAMES)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.SECTIONNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.PASS_CREATE_PROJECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.PROJECT_MANAGER_ID_PRE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.CONTRACT_PROJECT_FINISH_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.TENDER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.TEC_TRADE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.IS_FORBIDDEN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.IS_POINT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.IS_OLDCONTRACT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.OLDCONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.OLDCONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.FROMEVALUATION_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.MAINTENANCE_DATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT>()
                .Property(e => e.READ_EMPLOYEE_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH>()
                .Property(e => e.SOURCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH>()
                .Property(e => e.FILE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH>()
                .Property(e => e.FILENAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH>()
                .Property(e => e.FILE_EXT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH>()
                .Property(e => e.FILE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH>()
                .Property(e => e.FILE_SIZE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH_OTHER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH_OTHER>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH_OTHER>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH_OTHER>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH_OTHER>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH_OTHER>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH_OTHER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH_OTHER>()
                .Property(e => e.ATTACH_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_ATTACH_OTHER>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CHECK>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CHECK>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CHECK>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CHECK>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CHECK>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CHECK>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CHECK>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_CHECK>()
                .Property(e => e.CUSTOMER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_CHECK>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOM_SIGN>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOM_SIGN>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOM_SIGN>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOM_SIGN>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOM_SIGN>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOM_SIGN>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOM_SIGN>()
                .Property(e => e.CUSTOMER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOM_SIGN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOM_SIGN>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOM_SIGN>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOMER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOMER>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOMER>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOMER>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOMER>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOMER>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOMER>()
                .Property(e => e.CUSTOMER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOMER>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOMER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOMER>()
                .Property(e => e.CUSTOMER_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_CUSTOMER>()
                .Property(e => e.CUSTOMER_CONTACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_DOCUMENT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_DOCUMENT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_DOCUMENT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_DOCUMENT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_DOCUMENT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_DOCUMENT>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_DOCUMENT>()
                .Property(e => e.FLIE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_DOCUMENT>()
                .Property(e => e.COUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_DOCUMENT>()
                .Property(e => e.RECEIVE_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_DOCUMENT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_DOCUMENT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXECUTE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXECUTE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXECUTE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXECUTE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXECUTE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXECUTE>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXECUTE>()
                .Property(e => e.EXECUTE_CONDITION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXECUTE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXECUTE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXPENSE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXPENSE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXPENSE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXPENSE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXPENSE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXPENSE>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXPENSE>()
                .Property(e => e.EXPENSE_POOL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXPENSE>()
                .Property(e => e.SALES_CONTRACT_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXPENSE>()
                .Property(e => e.PRODUCT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXPENSE>()
                .Property(e => e.PERCENTAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXPENSE>()
                .Property(e => e.EXPENSE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXPENSE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXPENSE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_EXPENSE>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_IMPLEMENT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_IMPLEMENT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_IMPLEMENT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_IMPLEMENT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_IMPLEMENT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_IMPLEMENT>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_IMPLEMENT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_IMPLEMENT>()
                .Property(e => e.CUSTOMER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_IMPLEMENT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.PERCENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.IMG_URL)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.INVOICE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.INVOICE_COMPANY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.CUSTOMER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.INVOICE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.PAYMENT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.BANK_ACCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.INVOICE_COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.CUSTOMER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.INVOICE_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.TAX_REGISTRATION_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.BANK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.RECIPIENT_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.INVOICE_EMPLOYEE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.RECIPIENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.RECIPIENT_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.UPPER_AMOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.EXPECT_RETURN_MONEY_DATA)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.CUSTOMER_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.CUSTOMER_TELPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.ERP_INVOICE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.IC_CARD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.IS_PAY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.PERCENT2)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.NO_CONTRACT_INVOICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_INVOICE>()
                .Property(e => e.SALES_CONTRACT_INVOICE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.CONTRACT_PROJECT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.SECTION_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.COST_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.COST_RANGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.PERCENT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.ADD_PERCENT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.ADD_AMOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.ATTACH_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.SIGN_PRODUCT_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.PAYMENT_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.IS_MAIN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.MUST)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.SORT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.LINK_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.PLAN_PAYMENT_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.PLAN_SIGN_PRODUCT_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.SYS_MILESTONE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_MILESTONE>()
                .Property(e => e.PREDICT_WORKHOURS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PAYMENT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PAYMENT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PAYMENT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PAYMENT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PAYMENT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PAYMENT>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PAYMENT>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PAYMENT>()
                .Property(e => e.PERCENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PAYMENT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PAYMENT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_PAYMENT>()
                .Property(e => e.PLAN_CONDITION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PAYMENT>()
                .Property(e => e.DELAY_DAYS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PAYMENT>()
                .Property(e => e.IS_INVOICED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PAYMENT>()
                .Property(e => e.IS_WEEKDAY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PAYMENT>()
                .Property(e => e.COUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PAYMENT>()
                .Property(e => e.PAYMENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PAYMENT>()
                .Property(e => e.FINISH_PERCENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PAYMENT>()
                .Property(e => e.ISNEW)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PAYMENT>()
                .Property(e => e.SORT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PLAN>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PLAN>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PLAN>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PLAN>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PLAN>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PLAN>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PLAN>()
                .Property(e => e.SALES_PLAN_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PLAN>()
                .Property(e => e.PLAN_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.PRODUCT_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.PRODUCT_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.BASE_LIMIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.BASE_SALES_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.PRODUCT_REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.PRODUCT_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.TOTAL_LIMIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.TOTAL_SALES_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.TOTAL_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.TOTAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.PRODUCED_QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.MAINTENANCE_MONTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.EXTERNAL_PAYMENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.TAX_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.PRODUCT_PICTURE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.CUSTOMER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.SPECIFICATION)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.PRODUCT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.PRODUCT_MODEL)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.SUIT_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.COST)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.PROFIT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.PROJECT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.PRODUCT_TYPE_PERCENTAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.TOTAL_COST)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.REAL_TOTAL_COST)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_PRODUCT>()
                .Property(e => e.REMIND_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_RELATION>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_RELATION>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_RELATION>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_RELATION>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_RELATION>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_RELATION>()
                .Property(e => e.FROM_SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_RELATION>()
                .Property(e => e.TO_SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_RELATION>()
                .Property(e => e.RELATION_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.PRODUCT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.TOTAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.COMPLETION_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.MAINTENANCE_MONTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.SUBCONTRACT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.SPECIFICATION)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.SIGN_PRODUCT_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.FC_SIGN_PRODUCT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SIGN_PRODUCT>()
                .Property(e => e.RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SPEND>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SPEND>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SPEND>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SPEND>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SPEND>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SPEND>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SPEND>()
                .Property(e => e.DEPARTMENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SPEND>()
                .Property(e => e.EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SPEND>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SPEND>()
                .Property(e => e.SPEND_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_SPEND>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.BATCH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.SUB_CONTRACT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.SUB_SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.SUB_COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.SUB_COMPANY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.SUB_AMOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.SUB_REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.SUB_BELONG_YEAR)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.NOTICE_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.NOTICE_EMPLOYEE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.SUB_SALES_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.SUB_SALES_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.SUB_ATTACH_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.PERCENT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.CONFIRM_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.PURCHASE_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.BUSINESS_ALONG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.ISINNER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_SUBCONTRACT>()
                .Property(e => e.SUB_CONTRACT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_WRITEOFF>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_WRITEOFF>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_WRITEOFF>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_WRITEOFF>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_WRITEOFF>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_WRITEOFF>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_WRITEOFF>()
                .Property(e => e.TO_SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_WRITEOFF>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_CONTRACT_WRITEOFF>()
                .Property(e => e.TO_SALES_CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_WRITEOFF>()
                .Property(e => e.SALES_CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_WRITEOFF>()
                .Property(e => e.PROJECT_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_WRITEOFF>()
                .Property(e => e.PURCHASE_CONTRACT_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_WRITEOFF>()
                .Property(e => e.SALES_CONTRACT_INVOICE_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_WRITEOFF>()
                .Property(e => e.PURCHEASE_CONTRACT_NOS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_WRITEOFF>()
                .Property(e => e.WORK_HOURS_MAIN_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_CONTRACT_WRITEOFF>()
                .Property(e => e.FUNCTIONPOINT_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.SALES_PLAN_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.SALES_PLAN_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.CUSTOMER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.PROVINCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.CITY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.DISTRICT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.PROJECT_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.SALES_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.PROJECT_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.PRODUCT_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.PLAN_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_ATTACH>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_ATTACH>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_ATTACH>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_ATTACH>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_ATTACH>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_ATTACH>()
                .Property(e => e.SALES_PLAN_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_ATTACH>()
                .Property(e => e.FILE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_ATTACH>()
                .Property(e => e.FILE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_ATTACH>()
                .Property(e => e.FILE_EXT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_ATTACH>()
                .Property(e => e.FILE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_ATTACH>()
                .Property(e => e.FILE_SIZE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_ATTACH>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_CUSTOMER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_CUSTOMER>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_CUSTOMER>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_CUSTOMER>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_CUSTOMER>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_CUSTOMER>()
                .Property(e => e.SALES_PLAN_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_CUSTOMER>()
                .Property(e => e.CUSTOMER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_CUSTOMER>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_CUSTOMER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_CUSTOMER>()
                .Property(e => e.CUSTOMER_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_CUSTOMER>()
                .Property(e => e.CUSTOMER_CONTACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_DEVICE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_DEVICE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_DEVICE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_DEVICE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_DEVICE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_DEVICE>()
                .Property(e => e.SALES_PLAN_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_DEVICE>()
                .Property(e => e.DEVICE_MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_DEVICE>()
                .Property(e => e.OPERATING_SYSTEM)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_DEVICE>()
                .Property(e => e.DEVICE_PICTURE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_DEVICE>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_DEVICE>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_DEVICE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_OTHER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_OTHER>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_OTHER>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_OTHER>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_OTHER>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_OTHER>()
                .Property(e => e.SALES_PLAN_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_OTHER>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_OTHER>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_OTHER>()
                .Property(e => e.LIMIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_OTHER>()
                .Property(e => e.PROPOSAL_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_OTHER>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_OTHER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.SALES_PLAN_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.PRODUCT_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.PRODUCT_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.BASE_LIMIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.BASE_SALES_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.PRODUCT_REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.PRODUCT_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.TOTAL_LIMIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.TOTAL_SALES_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.PRODUCT_PICTURE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.TOTAL_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.CUSTOMER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.SPECIFICATION)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.MAINTENANCE_MONTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.PRODUCT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.PRODUCT_MODEL)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_PRODUCT>()
                .Property(e => e.SUIT_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_SOFTWARE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_SOFTWARE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_SOFTWARE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_SOFTWARE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_SOFTWARE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_SOFTWARE>()
                .Property(e => e.SALES_PLAN_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_SOFTWARE>()
                .Property(e => e.SOFTWARE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_SOFTWARE>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_SOFTWARE>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_SOFTWARE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SALES_PLAN_SOFTWARE>()
                .Property(e => e.LIMIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SALES_PLAN_SOFTWARE>()
                .Property(e => e.PROPOSAL_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.BEFORE_SALES_CONTRACT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.CHANGE_SALES_CONTRACT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.BEFORE_PROJECT_AMOUNT_PROFITS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.CHANGE_PROJECT_AMOUNT_PROFITS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.TEC_PROJECT_ACTUAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.TEC_BONUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.BEFORE_TEC_PERCENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.CHANGE_TEC_PERCENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.TEC_LIMIT_PECENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.BERORE_PROJECT_CONTRACT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.CHANGE_PROJECT_CONTRACT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.BEFORE_BUSINESS_PERCENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.CHANGE_BUSINESS_PERCENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.BUS_PROJECT_ACTUAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.BUSINESS_BONUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.BUS_LIMIT_PECENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.APPLY_EMPLOYEE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.APPLY_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.CONTRACT_INFO_CHNAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.PRODUCT_CHNAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.CUSTOMER_CHANGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.ATTACH_CHANGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE>()
                .Property(e => e.PAYMENT_CHANGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.CONTRACT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.CONTRACT_NO_BPM)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.BELONG_YEAR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.BUSINESS_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.TEAMWORK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.SALES_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.PROVINCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.CITY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.DISTRICT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.ISTENDER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.WINNINGBIDARCHIVE)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.MAINTENANCE_END_DATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.TEC_TRADE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.SALES_CONTRACT_CHANGE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.CUSTOMER_SIGN_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.CUSTOMER_USE_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.DATA_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.ATTACH_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.PROVINCE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.CITY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.DISTRICT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.SALES_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.PROJECT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_CONTRACT>()
                .Property(e => e.PROJECT_MANAGER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.TOTAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.MAINTENANCE_MONTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.SPECIFICATION)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.SIGN_PRODUCT_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.FC_SIGN_PRODUCT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.PROJECT_ACTUAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.PROJECT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.CUT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.DATA_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.SALES_CONTRACT_CHANGE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.PROJECT_MODEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_CHANGE_DETAIL>()
                .Property(e => e.SIGN_PRODUCT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_FINISH>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_FINISH>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_FINISH>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_FINISH>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_FINISH>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_FINISH>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_FINISH>()
                .Property(e => e.COMPANY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_FINISH>()
                .Property(e => e.DEPARTMENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_FINISH>()
                .Property(e => e.DEPARTMENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_FINISH>()
                .Property(e => e.APPLY_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_FINISH>()
                .Property(e => e.APPLY_EMPLOYEE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_FINISH>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_FINISH>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_FINISH_DETAIL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_FINISH_DETAIL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_FINISH_DETAIL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_FINISH_DETAIL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_FINISH_DETAIL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_FINISH_DETAIL>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_FINISH_DETAIL>()
                .Property(e => e.COMPANY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_FINISH_DETAIL>()
                .Property(e => e.DEPARTMENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_FINISH_DETAIL>()
                .Property(e => e.DEPARTMENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_FINISH_DETAIL>()
                .Property(e => e.PROJECT_MANAGER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_FINISH_DETAIL>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_FINISH_DETAIL>()
                .Property(e => e.PROJECT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_FINISH_DETAIL>()
                .Property(e => e.SC_FINISH_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_FINISH_DETAIL>()
                .Property(e => e.PROJECT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_FINISH_DETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE>()
                .Property(e => e.SALES_CONTRACT_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE>()
                .Property(e => e.PRODUCT_MODULE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE>()
                .Property(e => e.MODULE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE>()
                .Property(e => e.ADD_LIMIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE>()
                .Property(e => e.ADD_SALES_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE>()
                .Property(e => e.SELECT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.SALES_CONTRACT_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.SC_PRODUCT_MODULE_DETAIL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.PRODUCT_MODULE_DETAIL_ITEM_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.MODULE_DETAIL_ITEM_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.ADD_LIMIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.ADD_SALES_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.SELECT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.SC_PRODUCT_MODULE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.PRODUCT_MODULE_DETAIL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.MODULE_DETAIL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.SELECT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.SALES_CONTRACT_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.ADD_LIMIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SC_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.ADD_SALES_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_DEVICE_PARTS_MODEL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_DEVICE_PARTS_MODEL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_DEVICE_PARTS_MODEL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_DEVICE_PARTS_MODEL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_DEVICE_PARTS_MODEL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_DEVICE_PARTS_MODEL>()
                .Property(e => e.SALES_PLAN_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_DEVICE_PARTS_MODEL>()
                .Property(e => e.SALES_PLAN_DEVICE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_DEVICE_PARTS_MODEL>()
                .Property(e => e.SP_DEVICE_PARTS_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_DEVICE_PARTS_MODEL>()
                .Property(e => e.PARTS_MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_DEVICE_PARTS_MODEL>()
                .Property(e => e.PARTS_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SP_DEVICE_PARTS_TYPE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_DEVICE_PARTS_TYPE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_DEVICE_PARTS_TYPE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_DEVICE_PARTS_TYPE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_DEVICE_PARTS_TYPE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_DEVICE_PARTS_TYPE>()
                .Property(e => e.SALES_PLAN_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_DEVICE_PARTS_TYPE>()
                .Property(e => e.SALES_PLAN_DEVICE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_DEVICE_PARTS_TYPE>()
                .Property(e => e.PARTS_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_DEVICE_PARTS_TYPE>()
                .Property(e => e.REQUIRE_NUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE>()
                .Property(e => e.SALES_PLAN_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE>()
                .Property(e => e.PRODUCT_MODULE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE>()
                .Property(e => e.MODULE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE>()
                .Property(e => e.ADD_LIMIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE>()
                .Property(e => e.ADD_SALES_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE>()
                .Property(e => e.SELECT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE>()
                .Property(e => e.SALES_PLAN_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.SALES_PLAN_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.SALES_PLAN_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.SP_PRODUCT_MODULE_DETAIL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.PRODUCT_MODULE_DETAIL_ITEM_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.MODULE_DETAIL_ITEM_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.ADD_LIMIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.ADD_SALES_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.SELECT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_D_ITEM>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.SP_PRODUCT_MODULE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.PRODUCT_MODULE_DETAIL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.MODULE_DETAIL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.SELECT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.SALES_PLAN_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.SALES_PLAN_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.ADD_LIMIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.ADD_SALES_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_SOFTWARE_MODULE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_SOFTWARE_MODULE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_SOFTWARE_MODULE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_SOFTWARE_MODULE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_SOFTWARE_MODULE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_SOFTWARE_MODULE>()
                .Property(e => e.SALES_PLAN_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_SOFTWARE_MODULE>()
                .Property(e => e.SALES_PLAN_SOFTWARE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SP_SOFTWARE_MODULE>()
                .Property(e => e.SOFTWARE_MODULE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CONTACT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CONTACT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CONTACT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CONTACT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CONTACT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CONTACT>()
                .Property(e => e.ORG_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CONTACT>()
                .Property(e => e.CONTACT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CONTACT>()
                .Property(e => e.POSITION)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CONTACT>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CONTACT>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CONTACT>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CONTACT>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CONTACT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CONTACT>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.CUSTOMER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.PINYIN)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.ADDRESS_PROVINCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.ADDRESS_CITY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.ADDRESS_DISTRICT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.TAX_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.BANK_ACCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.BANK)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.COMPANY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.RANK)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.TELPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.REGISTER_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.ORG_TYPE_CODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.INVOICE_TELPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.OA_CUSTOMERID)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.CUSTOMER_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CUSTOMER>()
                .Property(e => e.CUSTOMER_CLASS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.SUPPLIER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.TAX_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.BANK_ACCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.BANK)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.TELPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.REGISTER_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.CONTACT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.LEGAL_REPRESENTATIVE)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.COMPANY_NATURE)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.COMPANY_SIZE)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.REGISTER_MONEY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.EMPLOYEE_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.SALES_AREA)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.PUBLICITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.MAIN_PRODUCE_DEVICE)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.MAIN_CHECK_DEVICE)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.QUALITY_ORGANIZATION)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.GRADE)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.ATTACHIDS)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.QUALITY_INSTITUTIONS)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.QUALITY_DIRECTOR)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.PROFESSIONAL_CHECKER)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.QUALITY_CONTROL_POINTS)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.QUALITY_RECORD)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.QUALITY_TRAINING)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.QUALITY_SYSTEM)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER>()
                .Property(e => e.SUPPLIER_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER_ATTACH>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER_ATTACH>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER_ATTACH>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER_ATTACH>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER_ATTACH>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER_ATTACH>()
                .Property(e => e.FILENAME)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER_ATTACH>()
                .Property(e => e.FILE_EXT)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER_ATTACH>()
                .Property(e => e.FILE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER_ATTACH>()
                .Property(e => e.FILE_SIZE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER_ATTACH>()
                .Property(e => e.UPLOAD_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER_ATTACH>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER_PRODUCT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER_PRODUCT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER_PRODUCT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER_PRODUCT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER_PRODUCT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER_PRODUCT>()
                .Property(e => e.PAY_TIME)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER_PRODUCT>()
                .Property(e => e.DELIVERY_TIME)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER_PRODUCT>()
                .Property(e => e.YEARS_SALES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_SUPPLIER_PRODUCT>()
                .Property(e => e.PRODUCT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CRM_SUPPLIER_PRODUCT>()
                .Property(e => e.SUPPLIER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_DEPT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_DEPT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_DEPT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_DEPT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_DEPT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_DEPT>()
                .Property(e => e.DEPT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_DEPT>()
                .Property(e => e.PARENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_DEPT>()
                .Property(e => e.DEPT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_TOKEN>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_TOKEN>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_TOKEN>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_TOKEN>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_TOKEN>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_TOKEN>()
                .Property(e => e.TEMPLATE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_TOKEN>()
                .Property(e => e.ACCESS_TOKEN)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_TOKEN>()
                .Property(e => e.REFRESH_TOKEN)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_TOKEN>()
                .Property(e => e.JS_API_TICKET)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_TOKEN>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_TOKEN>()
                .Property(e => e.APP_KEY)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_TOKEN>()
                .Property(e => e.APP_SECRET)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_TOKEN>()
                .Property(e => e.AGENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.UNION_ID)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.USER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.PHOTO_URL)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.TELEPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.JOB_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.ORG_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.DEPT_ID_LIST)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.DEPT_ORDER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.HIRED_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.ADMIN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.BOSS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.LEADER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.DEPT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DING_TALK_USER>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<DM_COMPONENT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_COMPONENT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_COMPONENT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_COMPONENT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_COMPONENT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_COMPONENT>()
                .Property(e => e.COMPONENT_MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_COMPONENT>()
                .Property(e => e.COMPONENT_SN)
                .IsUnicode(false);

            modelBuilder.Entity<DM_COMPONENT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_COMPONENT>()
                .Property(e => e.QUALITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_COMPONENT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<DM_COMPONENT>()
                .Property(e => e.DEVICE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_COMPONENT>()
                .Property(e => e.SOURCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_DEVICE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_DEVICE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_DEVICE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_DEVICE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_DEVICE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_DEVICE>()
                .Property(e => e.PURCHASE_ORDER_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_DEVICE>()
                .Property(e => e.CUSTOMER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_DEVICE>()
                .Property(e => e.DEVICE_MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_DEVICE>()
                .Property(e => e.DEVICE_SN)
                .IsUnicode(false);

            modelBuilder.Entity<DM_DEVICE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_DEVICE>()
                .Property(e => e.QUALITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_DEVICE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<DM_DEVICE>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_DEVICE>()
                .Property(e => e.SALES_CONTRACT_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_HIS_DEVICE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_HIS_DEVICE>()
                .Property(e => e.DEVICE_SN)
                .IsUnicode(false);

            modelBuilder.Entity<DM_HIS_DEVICE>()
                .Property(e => e.DEVICE_MODEL)
                .IsUnicode(false);

            modelBuilder.Entity<DM_HIS_DEVICE>()
                .Property(e => e.SALES_CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<DM_HIS_DEVICE>()
                .Property(e => e.ORDER_NO)
                .IsUnicode(false);

            modelBuilder.Entity<DM_HIS_DEVICE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<DM_HIS_PARTS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_HIS_PARTS>()
                .Property(e => e.HIS_DEVICE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_HIS_PARTS>()
                .Property(e => e.PARTS_SN)
                .IsUnicode(false);

            modelBuilder.Entity<DM_HIS_PARTS>()
                .Property(e => e.PARTS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DM_HIS_PARTS>()
                .Property(e => e.PARTS_MODEL)
                .IsUnicode(false);

            modelBuilder.Entity<DM_HIS_PARTS>()
                .Property(e => e.PARTS_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<DM_HIS_PARTS>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_CONTRACTPAYMENTMONTHPLAN>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_CONTRACTPAYMENTMONTHPLAN>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_CONTRACTPAYMENTMONTHPLAN>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_CONTRACTPAYMENTMONTHPLAN>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_CONTRACTPAYMENTMONTHPLAN>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_CONTRACTPAYMENTMONTHPLAN>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_CONTRACTPAYMENTMONTHPLAN>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL>()
                .Property(e => e.POOL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<FC_EXPENSE_POOL>()
                .Property(e => e.TOTAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL>()
                .Property(e => e.REMAIN_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<FC_EXPENSE_POOL>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL>()
                .Property(e => e.POOL_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL>()
                .Property(e => e.MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL>()
                .Property(e => e.POOL_NO)
                .IsUnicode(false);

            modelBuilder.Entity<FC_EXPENSE_POOL>()
                .Property(e => e.PROJECT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL>()
                .Property(e => e.DEPARTMENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL>()
                .Property(e => e.REIMBURSE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL_PERCENTAGE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL_PERCENTAGE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL_PERCENTAGE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL_PERCENTAGE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL_PERCENTAGE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL_PERCENTAGE>()
                .Property(e => e.SALES_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL_PERCENTAGE>()
                .Property(e => e.PRODUCT_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL_PERCENTAGE>()
                .Property(e => e.PERCENTAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL_PERCENTAGE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<FC_EXPENSE_POOL_PERCENTAGE>()
                .Property(e => e.EXPENSE_POOL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_EXPENSE_POOL_PERCENTAGE>()
                .Property(e => e.PROJECT_AREA_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT>()
                .Property(e => e.RECEIVE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT>()
                .Property(e => e.CUSTOMER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT>()
                .Property(e => e.SALES_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT>()
                .Property(e => e.RECORD_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT>()
                .Property(e => e.CONDITION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT>()
                .Property(e => e.WATERNUM)
                .IsUnicode(false);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT>()
                .Property(e => e.DEPTID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.MAINTABLE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.CUSTOMER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.AMOUNT_TOTAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.AMOUNT_RECEIVED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.AMOUNT_RECEIVE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.AMOUNT_NOTRECEIVE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.TICKET_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.AREA_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.DEPT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.CENTER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.CATEGORY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.PROJECTID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.AREA_MANAGER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.DEPT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.CENTER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.TICKET)
                .IsUnicode(false);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FC_RECEIVE_PAYMENT_DETAILS>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_ADDRESS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_ADDRESS>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_ADDRESS>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_ADDRESS>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_ADDRESS>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_ADDRESS>()
                .Property(e => e.ADDRESS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_ADDRESS>()
                .Property(e => e.ADDRESS_NO)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_ADDRESS>()
                .Property(e => e.PROVINCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_ADDRESS>()
                .Property(e => e.CITY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_ADDRESS>()
                .Property(e => e.DISTRICT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_ADDRESS>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_ADDRESS>()
                .Property(e => e.CONTACT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_ADDRESS>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_ADDRESS>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.CREATE_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.PROVINCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.CITY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.DISTRICT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.LINK_MAN)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.LINK_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.CUSTOMER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.DEVICE_SN)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.PROBLEM_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.DEVICE_LOCATION)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.SERVICE_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.HANDLE_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.HANDLE_RESULT)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.IS_CHANGE_PARTS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.RECORD_SOURCE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.RECORD_NO)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.ADDRESS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.ADDRESS_NO)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.ADDRESS_PROVINCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.ADDRESS_CITY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.ADDRESS_DISTRICT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.ADDRESS_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.ADDRESS_CONTACT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MT_CUSTOMER_SERVICE_RECORD>()
                .Property(e => e.ADDRESS_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.SEND_REPAIR_NO)
                .IsUnicode(false);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.WAREHOUSE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.REQUEST_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.EXPRESS_NO)
                .IsUnicode(false);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.SUPPLIER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.PROVINCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.CITY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.DISTRICT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.CONTACT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.SEND_REPAIR_TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.BACK_PROVINCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.BACK_CITY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.BACK_DISTRICT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.BACK_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.BACK_CONTACT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.BACK_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<MT_SEND_REPAIR>()
                .Property(e => e.BACK_EXPRESS_NO)
                .IsUnicode(false);

            modelBuilder.Entity<MT_SEND_REPAIR_ITEM>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR_ITEM>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR_ITEM>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR_ITEM>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR_ITEM>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR_ITEM>()
                .Property(e => e.SEND_REPAIR_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR_ITEM>()
                .Property(e => e.MODEL_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR_ITEM>()
                .Property(e => e.MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR_ITEM>()
                .Property(e => e.PRODUCT_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR_ITEM>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MT_SEND_REPAIR_ITEM>()
                .Property(e => e.PRODUCT_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<MT_SEND_REPAIR_ITEM>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR_ITEM>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR_ITEM>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MT_SEND_REPAIR_ITEM>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<MT_SEND_REPAIR_ITEM>()
                .Property(e => e.PARTS_SN)
                .IsUnicode(false);

            modelBuilder.Entity<MT_SEND_REPAIR_ITEM>()
                .Property(e => e.PARTS_FACTORY_SN)
                .IsUnicode(false);

            modelBuilder.Entity<MT_SEND_REPAIR_ITEM>()
                .Property(e => e.DEVICE_SN)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CONTRACT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_CONTRACT>()
                .Property(e => e.OA_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_CONTRACT>()
                .Property(e => e.COMPANY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CONTRACT>()
                .Property(e => e.SIGN_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CONTRACT>()
                .Property(e => e.CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CONTRACT>()
                .Property(e => e.CONTRACT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CONTRACT>()
                .Property(e => e.SALES_EMPLOYEE_ACCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CONTRACT>()
                .Property(e => e.OA_CUSTOMER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CONTRACT>()
                .Property(e => e.AMOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CONTRACT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CONTRACT>()
                .Property(e => e.OPERATE_MARK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_CONTRACT>()
                .Property(e => e.IS_SYNC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_CONTRACT>()
                .Property(e => e.OA_SYS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CONTRACT_PRODUCT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_CONTRACT_PRODUCT>()
                .Property(e => e.OA_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_CONTRACT_PRODUCT>()
                .Property(e => e.CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_CONTRACT_PRODUCT>()
                .Property(e => e.OA_CONTRACT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CONTRACT_PRODUCT>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CONTRACT_PRODUCT>()
                .Property(e => e.QUANTITY)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CONTRACT_PRODUCT>()
                .Property(e => e.PRICE)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CONTRACT_PRODUCT>()
                .Property(e => e.TOTAL_AMOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CONTRACT_PRODUCT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CONTRACT_PRODUCT>()
                .Property(e => e.OPERATE_MARK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_CONTRACT_PRODUCT>()
                .Property(e => e.IS_SYNC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_CONTRACT_PRODUCT>()
                .Property(e => e.OA_SYS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CUSTOMER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_CUSTOMER>()
                .Property(e => e.OA_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_CUSTOMER>()
                .Property(e => e.CUSTOMER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CUSTOMER>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CUSTOMER>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CUSTOMER>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CUSTOMER>()
                .Property(e => e.COMPANY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CUSTOMER>()
                .Property(e => e.TAX_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CUSTOMER>()
                .Property(e => e.BANK_ACCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CUSTOMER>()
                .Property(e => e.BANK)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CUSTOMER>()
                .Property(e => e.RANK)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CUSTOMER>()
                .Property(e => e.CONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CUSTOMER>()
                .Property(e => e.CONTACT_TELPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CUSTOMER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OA_CUSTOMER>()
                .Property(e => e.OPERATE_MARK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_CUSTOMER>()
                .Property(e => e.IS_SYNC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_CUSTOMER>()
                .Property(e => e.CUSTOMER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_CUSTOMER>()
                .Property(e => e.OA_SYS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_POOL_SALES_CONTRACT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_POOL_SALES_CONTRACT>()
                .Property(e => e.OA_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_POOL_SALES_CONTRACT>()
                .Property(e => e.SALES_CONTRACT_OA_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_POOL_SALES_CONTRACT>()
                .Property(e => e.POOL_OA_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_POOL_SALES_CONTRACT>()
                .Property(e => e.OPERATE_MARK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_POOL_SALES_CONTRACT>()
                .Property(e => e.IS_SYNC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_PROJECT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_PROJECT>()
                .Property(e => e.OA_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_PROJECT>()
                .Property(e => e.COMPANY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT>()
                .Property(e => e.PROJECT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT>()
                .Property(e => e.PROJECT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT>()
                .Property(e => e.PROJECT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT>()
                .Property(e => e.OA_CUSTOMER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT>()
                .Property(e => e.PROJECT_MANAGER_ACCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT>()
                .Property(e => e.CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT>()
                .Property(e => e.START_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT>()
                .Property(e => e.FINISH_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT>()
                .Property(e => e.WARNING_AMOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT>()
                .Property(e => e.LIMIT_AMOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT>()
                .Property(e => e.OPERATE_MARK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_PROJECT>()
                .Property(e => e.IS_SYNC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_PURCHASE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_PURCHASE>()
                .Property(e => e.OA_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_PURCHASE>()
                .Property(e => e.COMPANY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PURCHASE>()
                .Property(e => e.SIGN_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PURCHASE>()
                .Property(e => e.PURCHASE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PURCHASE>()
                .Property(e => e.PURCHASE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PURCHASE>()
                .Property(e => e.PURCHASE_EMPLOYEE_ACCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PURCHASE>()
                .Property(e => e.OA_SUPPLIER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PURCHASE>()
                .Property(e => e.AMOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PURCHASE>()
                .Property(e => e.EXPECT_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PURCHASE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PURCHASE>()
                .Property(e => e.OPERATE_MARK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_PURCHASE>()
                .Property(e => e.IS_SYNC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_PURCHASE>()
                .Property(e => e.OA_SYS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PURCHASE_PRODUCT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_PURCHASE_PRODUCT>()
                .Property(e => e.OA_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_PURCHASE_PRODUCT>()
                .Property(e => e.PURCHASE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_PURCHASE_PRODUCT>()
                .Property(e => e.OA_PURCHASE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PURCHASE_PRODUCT>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PURCHASE_PRODUCT>()
                .Property(e => e.QUANTITY)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PURCHASE_PRODUCT>()
                .Property(e => e.PRICE)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PURCHASE_PRODUCT>()
                .Property(e => e.TOTAL_AMOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PURCHASE_PRODUCT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PURCHASE_PRODUCT>()
                .Property(e => e.OPERATE_MARK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_PURCHASE_PRODUCT>()
                .Property(e => e.IS_SYNC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_PURCHASE_PRODUCT>()
                .Property(e => e.OA_SYS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CONTRACT_INVOICE>()
                .Property(e => e.OA_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_SALES_CONTRACT_INVOICE>()
                .Property(e => e.CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CONTRACT_INVOICE>()
                .Property(e => e.CONTRACT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CONTRACT_INVOICE>()
                .Property(e => e.INVOICE_COMPANY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CONTRACT_INVOICE>()
                .Property(e => e.CUSTOMER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CONTRACT_INVOICE>()
                .Property(e => e.INVOICE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CONTRACT_INVOICE>()
                .Property(e => e.INVOICE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CONTRACT_INVOICE>()
                .Property(e => e.INVOICE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CONTRACT_INVOICE>()
                .Property(e => e.INVOICE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_SALES_CONTRACT_INVOICE>()
                .Property(e => e.RECEIVE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_SALES_CONTRACT_INVOICE>()
                .Property(e => e.PAYMENT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CONTRACT_INVOICE>()
                .Property(e => e.BANK_AND_ACCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CONTRACT_INVOICE>()
                .Property(e => e.EMPLOYEE_ACCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CONTRACT_INVOICE>()
                .Property(e => e.EMPLOYEE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CONTRACT_INVOICE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CONTRACT_INVOICE>()
                .Property(e => e.IS_SYNC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_SALES_CONTRACT_RECEIVE>()
                .Property(e => e.OA_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_SALES_CONTRACT_RECEIVE>()
                .Property(e => e.CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CONTRACT_RECEIVE>()
                .Property(e => e.CONTRACT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CONTRACT_RECEIVE>()
                .Property(e => e.RECEIVE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_SALES_CONTRACT_RECEIVE>()
                .Property(e => e.OA_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_SALES_CONTRACT_RECEIVE>()
                .Property(e => e.CUSTOMER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CONTRACT_RECEIVE>()
                .Property(e => e.SALES_ACCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CONTRACT_RECEIVE>()
                .Property(e => e.SALES_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CONTRACT_RECEIVE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CONTRACT_RECEIVE>()
                .Property(e => e.IS_SYNC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_SUPPLIER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_SUPPLIER>()
                .Property(e => e.OA_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_SUPPLIER>()
                .Property(e => e.SUPPLIER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SUPPLIER>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SUPPLIER>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SUPPLIER>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SUPPLIER>()
                .Property(e => e.COMPANY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SUPPLIER>()
                .Property(e => e.TAX_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SUPPLIER>()
                .Property(e => e.BANK_ACCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SUPPLIER>()
                .Property(e => e.BANK)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SUPPLIER>()
                .Property(e => e.CONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SUPPLIER>()
                .Property(e => e.CONTACT_TELPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SUPPLIER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SUPPLIER>()
                .Property(e => e.OPERATE_MARK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_SUPPLIER>()
                .Property(e => e.IS_SYNC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_SUPPLIER>()
                .Property(e => e.SUPPLIER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_SUPPLIER>()
                .Property(e => e.OA_SYS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_ATTACH>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_ATTACH>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_ATTACH>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_ATTACH>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_ATTACH>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_ATTACH>()
                .Property(e => e.PRODUCE_SOURCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_ATTACH>()
                .Property(e => e.ATTACH_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_ATTACH>()
                .Property(e => e.FILENAME)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_ATTACH>()
                .Property(e => e.FILE_EXT)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_ATTACH>()
                .Property(e => e.FILE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_ATTACH>()
                .Property(e => e.FILE_SIZE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_ATTACH>()
                .Property(e => e.UPLOAD_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_MESSAGE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_MESSAGE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_MESSAGE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_MESSAGE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_MESSAGE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_MESSAGE>()
                .Property(e => e.SEND_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_MESSAGE>()
                .Property(e => e.RECEIVE_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_MESSAGE>()
                .Property(e => e.SEND_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_MESSAGE>()
                .Property(e => e.PRODUCE_SOURCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_MESSAGE>()
                .Property(e => e.MESSAGE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_MESSAGE>()
                .Property(e => e.IS_READ)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.PURCHASE_ORDER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.TASK_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.TASK_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.TASK_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.TASK_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.QC_STANDARD_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.TOTAL_QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.QUALIFIED_QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.QC_COUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.EMPLOYEE_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.OTHER_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.PASS_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.APPLY_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK>()
                .Property(e => e.CREATE_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_DETAIL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_DETAIL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_DETAIL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_DETAIL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_DETAIL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_DETAIL>()
                .Property(e => e.PRODUCE_TASK_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_DETAIL>()
                .Property(e => e.PRODUCE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_DETAIL>()
                .Property(e => e.PRODUCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_DETAIL>()
                .Property(e => e.QC_STANDARD_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_DETAIL>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_DETAIL>()
                .Property(e => e.QUALIFIED_QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_DETAIL>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.PRODUCE_TASK_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.QC_QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.TASK_RESULT)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.PLAN_WORKING_HOURS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.CONFIRM_WORKING_HOURS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.SPECIAL_HOURS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.SATISFACTION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.QUALITY_PENALTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.EVALUATE_RESULT)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.TRAVEL_EXPENSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.HOTEL_EXPENSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.TRAFFIC_EXPENSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.ACTIVITY_EXPENSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.OFFICE_EXPENSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.OTHER_EXPENSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.TRAVEL_WORKING_HOURS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_EMPLOYEE>()
                .Property(e => e.FREE_WORKING_HOURS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_PRODUCT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_PRODUCT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_PRODUCT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_PRODUCT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_PRODUCT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_PRODUCT>()
                .Property(e => e.PRODUCE_TASK_DETAIL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_PRODUCT>()
                .Property(e => e.PRODUCE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_PRODUCT>()
                .Property(e => e.PRODUCT_SN)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_TASK_PRODUCT>()
                .Property(e => e.QC_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_PRODUCT>()
                .Property(e => e.QC_RESULT)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_TASK_PRODUCT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_PRODUCT>()
                .Property(e => e.ITEM_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_PRODUCT>()
                .Property(e => e.QC_COUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_PRODUCT>()
                .Property(e => e.DEVICE_SN)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_TASK_QC_DETAIL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_QC_DETAIL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_QC_DETAIL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_QC_DETAIL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_QC_DETAIL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_QC_DETAIL>()
                .Property(e => e.PRODUCE_TASK_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_QC_DETAIL>()
                .Property(e => e.QC_STANDARD_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_QC_DETAIL>()
                .Property(e => e.STANDARD_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_TASK_QC_DETAIL>()
                .Property(e => e.STANDARD_SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_QC_DETAIL>()
                .Property(e => e.QC_STANDARD_ITEM_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_QC_DETAIL>()
                .Property(e => e.ITEM_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_TASK_QC_DETAIL>()
                .Property(e => e.QUALIFIED_STANDARD)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_TASK_QC_DETAIL>()
                .Property(e => e.ITEM_SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TASK_QC_DETAIL>()
                .Property(e => e.QC_ITEM_RESULT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK>()
                .Property(e => e.EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK>()
                .Property(e => e.PURCHASE_ORDER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK>()
                .Property(e => e.TRACK_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_TRACK>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_TRACK>()
                .Property(e => e.EMPLOYEE_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK>()
                .Property(e => e.APPLY_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK>()
                .Property(e => e.CREATE_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.PRODUCE_TRACK_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.PRODUCE_PROCESS_RECORD)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.PLAN_WORKING_HOURS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.CONFIRM_WORKING_HOURS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.SPECIAL_HOURS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.SATISFACTION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.QUALITY_PENALTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.EVALUATE_RESULT)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.TRAVEL_EXPENSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.HOTEL_EXPENSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.TRAFFIC_EXPENSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.ACTIVITY_EXPENSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.OFFICE_EXPENSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.OTHER_EXPENSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.TRAVEL_WORKING_HOURS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_PRODUCE_TRACK_EMPLOYEE>()
                .Property(e => e.FREE_WORKING_HOURS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_MODEL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_MODEL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_MODEL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_MODEL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_MODEL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_MODEL>()
                .Property(e => e.STANDARD_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_MODEL>()
                .Property(e => e.MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_MODEL>()
                .Property(e => e.MODEL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PC_QC_MODEL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PC_QC_MODEL_STANDARD>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_MODEL_STANDARD>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_MODEL_STANDARD>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_MODEL_STANDARD>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_MODEL_STANDARD>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_MODEL_STANDARD>()
                .Property(e => e.QC_MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_MODEL_STANDARD>()
                .Property(e => e.QC_STANDARD_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_MODEL_STANDARD>()
                .Property(e => e.QC_STANDARD_ITEM_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_STANDARD>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_STANDARD>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_STANDARD>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_STANDARD>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_STANDARD>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_STANDARD>()
                .Property(e => e.STANDARD_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PC_QC_STANDARD>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_STANDARD>()
                .Property(e => e.STANDARD_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_STANDARD_ITEM>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_STANDARD_ITEM>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_STANDARD_ITEM>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_STANDARD_ITEM>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_STANDARD_ITEM>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_STANDARD_ITEM>()
                .Property(e => e.QC_STANDARD_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PC_QC_STANDARD_ITEM>()
                .Property(e => e.ITEM_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PC_QC_STANDARD_ITEM>()
                .Property(e => e.QUALIFIED_STANDARD)
                .IsUnicode(false);

            modelBuilder.Entity<PC_QC_STANDARD_ITEM>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS>()
                .Property(e => e.BORROW_MONTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS>()
                .Property(e => e.PARTS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PM_BORROW_PARTS>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS>()
                .Property(e => e.RECEIVER_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS>()
                .Property(e => e.SUPPLIER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS>()
                .Property(e => e.SUPPLIER_CONTACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PM_BORROW_PARTS>()
                .Property(e => e.PARTS_MODEL)
                .IsUnicode(false);

            modelBuilder.Entity<PM_BORROW_PARTS>()
                .Property(e => e.RETURN_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<PM_BORROW_PARTS_DETAIL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS_DETAIL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS_DETAIL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS_DETAIL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS_DETAIL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS_DETAIL>()
                .Property(e => e.BORROW_PARTS_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS_DETAIL>()
                .Property(e => e.BORROW_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS_DETAIL>()
                .Property(e => e.RETURN_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS_DETAIL>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS_DETAIL>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_BORROW_PARTS_DETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.PARTS_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.COMPONENT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.PARTS_MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.COMPONENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.COMPONENT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.FACTORY_MODEL)
                .IsUnicode(false);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.SUPPLIER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.UNIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.SPECIFICATION)
                .IsUnicode(false);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.MAINTENANCE_PERIOD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.IS_STICK_BARCODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.SUIT_PARTS_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PM_COMPONENT_MODEL>()
                .Property(e => e.PICTURE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<PM_DEVICE_MODEL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL>()
                .Property(e => e.MAIN_MODEL)
                .IsUnicode(false);

            modelBuilder.Entity<PM_DEVICE_MODEL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PM_DEVICE_MODEL>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL>()
                .Property(e => e.DEVICE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PM_DEVICE_MODEL>()
                .Property(e => e.DEVICE_PICTURE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_MODEL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_MODEL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_MODEL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_MODEL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_MODEL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_MODEL>()
                .Property(e => e.DEVICE_MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_MODEL>()
                .Property(e => e.DEVICE_MODEL_PARTS_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_MODEL>()
                .Property(e => e.PARTS_MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_MODEL>()
                .Property(e => e.IS_DEFAULT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_MODEL>()
                .Property(e => e.PARTS_REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_TYPE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_TYPE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_TYPE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_TYPE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_TYPE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_TYPE>()
                .Property(e => e.DEVICE_MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_TYPE>()
                .Property(e => e.PARTS_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_TYPE>()
                .Property(e => e.REQUIRE_NUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_TYPE>()
                .Property(e => e.IS_NEED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_DEVICE_MODEL_PARTS_TYPE>()
                .Property(e => e.IS_MULTI)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.PARTS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.PARTS_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.FACTORY_MODEL)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.SUPPLIER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.UNIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.SPECIFICATION)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.HAS_COMPONENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.PARENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.DEFAULT_SOURCE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.ATTRIBUTE)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.MAINTENANCE_PERIOD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.FIRMWARE_VER)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.PICTURE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.PARTS_TYPE_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.BRAND)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.DELIVERY_DAYS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.PAYMENT_DAYS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL>()
                .Property(e => e.IS_BARCODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL_COMPONENT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL_COMPONENT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL_COMPONENT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL_COMPONENT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL_COMPONENT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL_COMPONENT>()
                .Property(e => e.PARTS_MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL_COMPONENT>()
                .Property(e => e.COMPONENT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PARTS_MODEL_COMPONENT>()
                .Property(e => e.COMPONENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PARTS_MODEL_COMPONENT>()
                .Property(e => e.FACTORY_MODEL)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PARTS_MODEL_COMPONENT>()
                .Property(e => e.SPECIFICATION)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PARTS_MODEL_COMPONENT>()
                .Property(e => e.NUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL_COMPONENT>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PARTS_MODEL_COMPONENT>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_MODEL_COMPONENT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PARTS_TYPE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_TYPE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_TYPE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_TYPE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_TYPE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_TYPE>()
                .Property(e => e.TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PARTS_TYPE>()
                .Property(e => e.PINYIN)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PARTS_TYPE>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_TYPE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PARTS_TYPE>()
                .Property(e => e.TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.PRODUCT_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.SPECIFICATION)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.BASE_LIMIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.BASE_SALES_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.PRODUCT_PICTURE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.LINK_DEVICE_MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.PRODUCT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.PRODUCT_MODEL)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.SUIT_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.PRODUCT_EXAMINE_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.PRODUCT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.PARENT_PRODUCT_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.BUSINESS_DOMAIN_TAG_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.APPLICATION_TYPE_TAG_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.CUSTOMER_GROUP_TAG_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.BUSINESS_SEGMENTS_TAG_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.ISSOFTWRITING)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.SOFTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.STANDARDNAME1_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.FUNCTIONMODULE)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.BACKGROUND)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT>()
                .Property(e => e.STANDARDNAME2_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE>()
                .Property(e => e.PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE>()
                .Property(e => e.MODULE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT_MODULE>()
                .Property(e => e.ADD_LIMIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE>()
                .Property(e => e.ADD_SALES_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE>()
                .Property(e => e.SELECT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT_MODULE>()
                .Property(e => e.MIN_SUB_SELECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE>()
                .Property(e => e.MAX_SUB_SELECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE>()
                .Property(e => e.LINK_PARTS_TYPE_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.PRODUCT_MODULE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.MODULE_DETAIL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.SELECT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.ADD_LIMIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.ADD_SALES_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.MIN_SUB_SELECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL>()
                .Property(e => e.MAX_SUB_SELECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL_ITEM>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL_ITEM>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL_ITEM>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL_ITEM>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL_ITEM>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL_ITEM>()
                .Property(e => e.PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL_ITEM>()
                .Property(e => e.PRODUCT_MODULE_DETAIL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL_ITEM>()
                .Property(e => e.MODULE_DETAIL_ITEM_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL_ITEM>()
                .Property(e => e.SELECT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL_ITEM>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL_ITEM>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL_ITEM>()
                .Property(e => e.ADD_LIMIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_DETAIL_ITEM>()
                .Property(e => e.ADD_SALES_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_MUTEX>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_MUTEX>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_MUTEX>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_MUTEX>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_MUTEX>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_MUTEX>()
                .Property(e => e.PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_MUTEX>()
                .Property(e => e.PRODUCT_MODULE_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT_MODULE_MUTEX>()
                .Property(e => e.MODULE_COUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_MUTEX>()
                .Property(e => e.MIN_MUTEX_SELECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_MODULE_MUTEX>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT_MODULE_MUTEX>()
                .Property(e => e.MAX_MUTEX_SELECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE>()
                .Property(e => e.PARENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE>()
                .Property(e => e.PRODUCT_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT_TYPE>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT_TYPE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE>()
                .Property(e => e.NEED_PURCHASE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE>()
                .Property(e => e.WITH_TRAVEL_EXPENSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE>()
                .Property(e => e.WITH_BONUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE>()
                .Property(e => e.NEED_ORDER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE>()
                .Property(e => e.ID_PATH)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT_TYPE>()
                .Property(e => e.PERCENTAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE>()
                .Property(e => e.NEED_SUBCONTRACT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE>()
                .Property(e => e.BUSINESS_PERCENTAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_CONFIG>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_CONFIG>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_CONFIG>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_CONFIG>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_CONFIG>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_CONFIG>()
                .Property(e => e.PRODUCT_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_CONFIG>()
                .Property(e => e.TAX_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_CONFIG>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_OLD>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_OLD>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_OLD>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_OLD>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_OLD>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_OLD>()
                .Property(e => e.PARENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_OLD>()
                .Property(e => e.PRODUCT_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT_TYPE_OLD>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_OLD>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT_TYPE_OLD>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_OLD>()
                .Property(e => e.NEED_PURCHASE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_OLD>()
                .Property(e => e.NEED_ORDER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_OLD>()
                .Property(e => e.WITH_TRAVEL_EXPENSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_OLD>()
                .Property(e => e.WITH_BONUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TYPE_OLD>()
                .Property(e => e.ID_PATH)
                .IsUnicode(false);

            modelBuilder.Entity<PM_SIGN_PRODUCT_TYPE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SIGN_PRODUCT_TYPE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SIGN_PRODUCT_TYPE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SIGN_PRODUCT_TYPE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SIGN_PRODUCT_TYPE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SIGN_PRODUCT_TYPE>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SIGN_PRODUCT_TYPE>()
                .Property(e => e.PRODUCT_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PM_SIGN_PRODUCT_TYPE>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SIGN_PRODUCT_TYPE>()
                .Property(e => e.PARENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SIGN_PRODUCT_TYPE>()
                .Property(e => e.DEEP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SIGN_PRODUCT_TYPE>()
                .Property(e => e.DEEP_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PM_SOFTWARE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SOFTWARE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SOFTWARE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SOFTWARE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SOFTWARE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SOFTWARE>()
                .Property(e => e.SOFTWARE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PM_SOFTWARE>()
                .Property(e => e.VERSION)
                .IsUnicode(false);

            modelBuilder.Entity<PM_SOFTWARE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SOFTWARE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PM_SOFTWARE>()
                .Property(e => e.LIMIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SOFTWARE>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SOFTWARE_MODULE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SOFTWARE_MODULE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SOFTWARE_MODULE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SOFTWARE_MODULE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SOFTWARE_MODULE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SOFTWARE_MODULE>()
                .Property(e => e.SOFTWARE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SOFTWARE_MODULE>()
                .Property(e => e.MODULE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PM_SOFTWARE_MODULE>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SOFTWARE_MODULE>()
                .Property(e => e.IS_OPTIONAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SOFTWARE_MODULE>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_SOFTWARE_MODULE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PM_SOFTWARE_MODULE>()
                .Property(e => e.LIMIT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_TEST_REPORT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_TEST_REPORT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_TEST_REPORT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_TEST_REPORT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_TEST_REPORT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_TEST_REPORT>()
                .Property(e => e.SOURCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_TEST_REPORT>()
                .Property(e => e.FILENAME)
                .IsUnicode(false);

            modelBuilder.Entity<PM_TEST_REPORT>()
                .Property(e => e.FILE_EXT)
                .IsUnicode(false);

            modelBuilder.Entity<PM_TEST_REPORT>()
                .Property(e => e.FILE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<PM_TEST_REPORT>()
                .Property(e => e.FILE_SIZE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_TEST_REPORT>()
                .Property(e => e.UPLOAD_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.PURCHASE_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.PURCHASE_APPLY_ITEM_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.PURCHASE_APPLY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.PURCHASE_ORDER_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.PRODUCT_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.MAINTENANCE_MONTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.SPECIFIC_SUPPLIER)
                .IsUnicode(false);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.SPECIFICATION)
                .IsUnicode(false);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.TOTAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.COMPLETION_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.PRODUCT_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.IN_STORE_QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.OUT_STORE_QUANTIY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.SOURCE)
                .IsUnicode(false);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.MAINTENANCE_MONTH_REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT>()
                .Property(e => e.SALES_CONTRACT_SIGN_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT_DETAIL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT_DETAIL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT_DETAIL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT_DETAIL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT_DETAIL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT_DETAIL>()
                .Property(e => e.P_C_SIGN_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT_DETAIL>()
                .Property(e => e.PRODUCT_DETAIL_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT_DETAIL>()
                .Property(e => e.PRODUCT_DETAIL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT_DETAIL>()
                .Property(e => e.PRODUCT_DETAIL_SPEC)
                .IsUnicode(false);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT_DETAIL>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT_DETAIL>()
                .Property(e => e.REQUIRE_NUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT_DETAIL>()
                .Property(e => e.TOTAL_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT_DETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT_DETAIL>()
                .Property(e => e.P_O_PRODUCT_PARTS_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT_DETAIL>()
                .Property(e => e.PURCHASE_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT_DETAIL>()
                .Property(e => e.SOURCE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_C_SIGN_PRODUCT_DETAIL>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS>()
                .Property(e => e.PURCHASE_ORDER_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS>()
                .Property(e => e.PARTS_MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS>()
                .Property(e => e.REQUIRE_NUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS>()
                .Property(e => e.PURCHASE_ORDER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS>()
                .Property(e => e.SOURCE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS>()
                .Property(e => e.SEND_REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS>()
                .Property(e => e.IS_SEND_EMAIL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS>()
                .Property(e => e.IS_CONTRACT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS>()
                .Property(e => e.REFORM_MARK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS>()
                .Property(e => e.MODIFY_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS>()
                .Property(e => e.PARTS_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS_TYPE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS_TYPE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS_TYPE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS_TYPE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS_TYPE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS_TYPE>()
                .Property(e => e.PURCHASE_ORDER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS_TYPE>()
                .Property(e => e.PURCHASE_ORDER_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS_TYPE>()
                .Property(e => e.PARTS_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS_TYPE>()
                .Property(e => e.REQUIRE_NUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS_TYPE>()
                .Property(e => e.SUGGEST_PARTS_BRAND)
                .IsUnicode(false);

            modelBuilder.Entity<PO_P_O_PRODUCT_PARTS_TYPE>()
                .Property(e => e.MODIFY_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.APPLY_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.PURCHASE_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.ATTACH_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.PURCHASE_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.APPLY_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.PURCHASE_APPLY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.IS_SPECIFIC_SUPPLIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.SPECIFIC_SUPPLIER)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.ITEM_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.APPLY_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.DEPARTMENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.SOURCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY>()
                .Property(e => e.RECEIVEINFO)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ATTACH>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ATTACH>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ATTACH>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ATTACH>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ATTACH>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ATTACH>()
                .Property(e => e.UPLOAD_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ATTACH>()
                .Property(e => e.FILENAME)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ATTACH>()
                .Property(e => e.FILE_EXT)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ATTACH>()
                .Property(e => e.FILE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ATTACH>()
                .Property(e => e.FILE_SIZE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ATTACH>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ATTACH>()
                .Property(e => e.SOURCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.PURCHASE_APPLY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.SALES_CONTRACT_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.SPECIFIC_SUPPLIER)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.CUSTOMER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.SPEC_PARAM)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.PURCHASE_QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.MAINTENANCE_MONTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.MAINTENANCE_MONTH_REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.DEF1)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.DEF2)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.DEF3)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.DEF4)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.DEF5)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.DEF6)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.DEF7)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_ITEM>()
                .Property(e => e.DEF8)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.PURCHASE_ORDER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.PURCHASE_ORDER_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.PURCHASE_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.SUPPLIER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.SUPPLIER_CONTACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.CREATE_COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.SUB_COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.PURCHASE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.PURCHASE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.BELONG_YEAR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.PURCHASE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.IS_SEND_EMAIL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.DISCOUNT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.IS_SUBCONTRACT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.SUPPLIER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.DEPARTMENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.FRAME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.PURCHASE_NO_INNER)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.SOURCE)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.IS_WRITEOFF)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.PURCHASE_PRODUCT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.IS_ORDER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.ISCONSULTING)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.REMARK2)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT>()
                .Property(e => e.AUTO_IN_OUT_STOCK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_ATTACH>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_ATTACH>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_ATTACH>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_ATTACH>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_ATTACH>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_ATTACH>()
                .Property(e => e.PURCHASE_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_ATTACH>()
                .Property(e => e.FILE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_ATTACH>()
                .Property(e => e.FILENAME)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_ATTACH>()
                .Property(e => e.FILE_EXT)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_ATTACH>()
                .Property(e => e.FILE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_ATTACH>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_ATTACH>()
                .Property(e => e.FILE_SIZE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_INVOICE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_INVOICE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_INVOICE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_INVOICE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_INVOICE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_INVOICE>()
                .Property(e => e.PURCHASE_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_INVOICE>()
                .Property(e => e.INVOICE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_INVOICE>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_INVOICE>()
                .Property(e => e.PERCENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_INVOICE>()
                .Property(e => e.IMG_URL)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_INVOICE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_INVOICE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_INVOICE>()
                .Property(e => e.INVOICE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_INVOICE>()
                .Property(e => e.RATE)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PAYMENT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PAYMENT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PAYMENT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PAYMENT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PAYMENT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PAYMENT>()
                .Property(e => e.PURCHASE_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PAYMENT>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PAYMENT>()
                .Property(e => e.PERCENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PAYMENT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PAYMENT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PAYMENT>()
                .Property(e => e.PLAN_CONDITION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PAYMENT>()
                .Property(e => e.DELAY_DAYS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.PURCHASE_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.PRODUCT_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.TOTAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.PURCHASE_ORDER_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.MAINTENANCE_MONTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.BATCH)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.SALES_CONTRACT_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.STOCK_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.LINK_SIGN_PRODUCT_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.LINK_SIGN_PRODUCT_COUNT)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.SPECIFICATION)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.PRODUCT_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.PRODUCT_REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.PURCHASE_ORDER_PARTS_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.PRODUCT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.PRODUCT_MODEL)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_PRODUCT>()
                .Property(e => e.SUIT_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_RELATION>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_RELATION>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_RELATION>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_RELATION>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_RELATION>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_RELATION>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_RELATION>()
                .Property(e => e.PURCHASE_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_CONTRACT_RELATION>()
                .Property(e => e.RELATION_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_EMAIL_LOG>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_EMAIL_LOG>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_EMAIL_LOG>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_EMAIL_LOG>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_EMAIL_LOG>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_EMAIL_LOG>()
                .Property(e => e.SOURCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_EMAIL_LOG>()
                .Property(e => e.TARGET_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_EMAIL_LOG>()
                .Property(e => e.SEND_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_EMAIL_LOG>()
                .Property(e => e.EMAIL_TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_EMAIL_LOG>()
                .Property(e => e.EMAIL_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_EMAIL_LOG>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_EMAIL_LOG>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_EMAIL_LOG>()
                .Property(e => e.EMAIL_ATTACH)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_EMAIL_LOG>()
                .Property(e => e.SOURCE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_EMPLOYEE_AREA>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_EMPLOYEE_AREA>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_EMPLOYEE_AREA>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_EMPLOYEE_AREA>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_EMPLOYEE_AREA>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_EMPLOYEE_AREA>()
                .Property(e => e.EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_EMPLOYEE_AREA>()
                .Property(e => e.AREA_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_EMPLOYEE_AREA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_EMPLOYEE_AREA>()
                .Property(e => e.PURCHASE_APPLY_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.ORDER_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.ORDER_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.SUPPLIER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.SUPPLIER_CONTACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.SUPPLIER_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.IS_SEND_EMAIL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.IS_URGENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.TOTAL_QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.PURCHASE_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.IS_REFORM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.MODIFY_COUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.IS_COMPLETE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.IS_PROTOTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.ORDER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.PURCHASE_APPLY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER>()
                .Property(e => e.ORDER_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_ATTACH>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_ATTACH>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_ATTACH>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_ATTACH>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_ATTACH>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_ATTACH>()
                .Property(e => e.PURCHASE_ORDER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_ATTACH>()
                .Property(e => e.FILE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_ATTACH>()
                .Property(e => e.FILE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_ATTACH>()
                .Property(e => e.FILE_EXT)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_ATTACH>()
                .Property(e => e.FILE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_ATTACH>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_ATTACH>()
                .Property(e => e.FILE_SIZE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.PURCHASE_ORDER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.PARTS_MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.BATCH)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.SOURCE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.REFORM_MARK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.TRACK_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.PARTS_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.PARTS_TRACK_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.TRACK_STOCK_IO_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.TRACK_QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.CONFIRM_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.PRODUCT_SNS)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.PRODUCT_SUPPLIER_SNS)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.MAINTENANCE_MONTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS>()
                .Property(e => e.LINK_STOCK_BATCH_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_PICKED>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_PICKED>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_PICKED>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_PICKED>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_PICKED>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_PICKED>()
                .Property(e => e.PURCHASE_ORDER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_PICKED>()
                .Property(e => e.PARTS_MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_PICKED>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_PICKED>()
                .Property(e => e.BATCH)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_PICKED>()
                .Property(e => e.SOURCE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_PICKED>()
                .Property(e => e.PRODUCT_SN)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.PARTS_TRACK_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.PURCHASE_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.PURCHASE_ORDER_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.PURCHASE_ORDER_NOS)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.PARTS_TRACK_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.SUPPLIER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.PARTS_MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.PARTS_TRACK_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.TRACK_STOCK_IO_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.CONFIRM_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.BATCH)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.PRODUCT_SUPPLIER_SNS)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PARTS_TRACK>()
                .Property(e => e.PRODUCT_SNS)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PRODUCT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PRODUCT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PRODUCT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PRODUCT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PRODUCT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PRODUCT>()
                .Property(e => e.PURCHASE_ORDER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PRODUCT>()
                .Property(e => e.BATCH)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PRODUCT>()
                .Property(e => e.MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PRODUCT>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PRODUCT>()
                .Property(e => e.DEVICE_PICTURE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PRODUCT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PRODUCT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PRODUCT>()
                .Property(e => e.OPERATING_SYSTEM)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PRODUCT>()
                .Property(e => e.SALES_CONTRACT_PRODUCT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PRODUCT>()
                .Property(e => e.IS_REFORM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PRODUCT>()
                .Property(e => e.MODIFY_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PRODUCT>()
                .Property(e => e.STOCK_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_ORDER_PRODUCT>()
                .Property(e => e.DEVICE_SN)
                .IsUnicode(false);

            modelBuilder.Entity<PR_BUSINESS_SPLIT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT>()
                .Property(e => e.PROJECT_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PR_BUSINESS_SPLIT>()
                .Property(e => e.PROJECT_AMOUNT_PROFITS)
                .IsUnicode(false);

            modelBuilder.Entity<PR_BUSINESS_SPLIT>()
                .Property(e => e.APPLY_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT>()
                .Property(e => e.APPLY_EMPLOYEE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_BUSINESS_SPLIT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_BUSINESS_SPLIT>()
                .Property(e => e.PROJECT_ACTUAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT>()
                .Property(e => e.WRITE_OFF_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT>()
                .Property(e => e.BONUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT>()
                .Property(e => e.BUSINESS_ALONG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT>()
                .Property(e => e.TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT_DETAIL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT_DETAIL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT_DETAIL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT_DETAIL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT_DETAIL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT_DETAIL>()
                .Property(e => e.PROJECT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_BUSINESS_SPLIT_DETAIL>()
                .Property(e => e.PROJECT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT_DETAIL>()
                .Property(e => e.PROJECT_MANAGER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_BUSINESS_SPLIT_DETAIL>()
                .Property(e => e.PROJECT_ACTUAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT_DETAIL>()
                .Property(e => e.BONUS)
                .IsUnicode(false);

            modelBuilder.Entity<PR_BUSINESS_SPLIT_DETAIL>()
                .Property(e => e.TOTAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT_DETAIL>()
                .Property(e => e.WRITE_OFF_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT_DETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_BUSINESS_SPLIT_DETAIL>()
                .Property(e => e.BUSINESS_SPLIT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_BUSINESS_SPLIT_DETAIL>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_P_F_POOL_IN_OUT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_P_F_POOL_IN_OUT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_P_F_POOL_IN_OUT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_P_F_POOL_IN_OUT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_P_F_POOL_IN_OUT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_P_F_POOL_IN_OUT>()
                .Property(e => e.PROJECT_FUNDS_POOL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_P_F_POOL_IN_OUT>()
                .Property(e => e.IN_OUT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_P_F_POOL_IN_OUT>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_P_F_POOL_IN_OUT>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_P_F_POOL_IN_OUT>()
                .Property(e => e.PROJECT_SPEND_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_P_F_POOL_IN_OUT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_P_F_POOL_IN_OUT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_P_F_POOL_IN_OUT>()
                .Property(e => e.PROJECTNO)
                .IsUnicode(false);

            modelBuilder.Entity<PR_P_F_POOL_IN_OUT>()
                .Property(e => e.EXPENSE_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<PR_P_F_POOL_IN_OUT>()
                .Property(e => e.EXPENSE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PR_P_F_POOL_IN_OUT>()
                .Property(e => e.CHANGED_PROJECT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_P_F_POOL_IN_OUT>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.PROJECT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.PROJECT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.CUSTOMER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.TOTAL_SPEND_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.PROVINCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.CITY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.DISTRICT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.PROJECT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.IMPLEMENT_EMPLOYEE_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.IMPLEMENT_EMPLOYEE_NAMES)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.SALES_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.REIMBURSABLE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.TOTAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.PROJECT_CATEGORY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.ACTUAL_PROJECT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.PROJECT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.PROJECT_AMOUNT_PROFITS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.SALES_CONTRACT_PRODUCT_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.PROJECT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.PROJECT_ACTUAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.PROGRESS_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.PROJECT_MODEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.FCPROJECTTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.FCPROJECTNO)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.FCPROJECTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.CUSTOMER_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.SOURCE)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.DEPARTMENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.OVER_BUDGET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.APPLY_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.APPLY_EMPLOYEE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.PROJECT_PRODUCT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.TEAM_WORK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.BUSINESS_ALONG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.IS_NEW)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.WORKFLOWNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.PROJECT_BONUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.WRITEOFF_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT>()
                .Property(e => e.FROZENREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_AMOUNT_ADJUST>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_AMOUNT_ADJUST>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_AMOUNT_ADJUST>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_AMOUNT_ADJUST>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_AMOUNT_ADJUST>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_AMOUNT_ADJUST>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_AMOUNT_ADJUST>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_AMOUNT_ADJUST>()
                .Property(e => e.ADJUST_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_AMOUNT_ADJUST>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_AMOUNT_ADJUST>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_AMOUNT_ADJUST>()
                .Property(e => e.APPLY_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_AMOUNT_ADJUST>()
                .Property(e => e.APPLY_EMPLOYEE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_AMOUNT_ADJUST>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_AMOUNT_ADJUST>()
                .Property(e => e.BEFORE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_AMOUNT_ADJUST>()
                .Property(e => e.AFTER_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_ATTACH>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_ATTACH>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_ATTACH>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_ATTACH>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_ATTACH>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_ATTACH>()
                .Property(e => e.SOURCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_ATTACH>()
                .Property(e => e.FILE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_ATTACH>()
                .Property(e => e.FILENAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_ATTACH>()
                .Property(e => e.FILE_EXT)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_ATTACH>()
                .Property(e => e.FILE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_ATTACH>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_ATTACH>()
                .Property(e => e.FILE_SIZE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BID>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BID>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BID>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BID>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BID>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BID>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BID>()
                .Property(e => e.BID_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_BID>()
                .Property(e => e.IS_BOND)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BID>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BID>()
                .Property(e => e.EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BID>()
                .Property(e => e.BID_FILE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_BID>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BID>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_BONUS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS>()
                .Property(e => e.APPLY_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS>()
                .Property(e => e.BONUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_BONUS>()
                .Property(e => e.P_F_POOL_IN_OUT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS>()
                .Property(e => e.POOL_BONUS_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS>()
                .Property(e => e.PROJECT_BONUS_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS>()
                .Property(e => e.IS_IMPORT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS>()
                .Property(e => e.RE_POOL_BONUS_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS>()
                .Property(e => e.RE_PROJECT_BONUS_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_DETAIL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_DETAIL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_DETAIL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_DETAIL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_DETAIL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_DETAIL>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_DETAIL>()
                .Property(e => e.BONUSE_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_DETAIL>()
                .Property(e => e.PROJECT_BONUS_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_DETAIL>()
                .Property(e => e.BONUS_EMPLOYEE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_BONUS_DETAIL>()
                .Property(e => e.PERCENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_DETAIL>()
                .Property(e => e.BONUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_DETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_BONUS_IMPORT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_IMPORT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_IMPORT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_IMPORT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_IMPORT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_IMPORT>()
                .Property(e => e.PROJECT_BONUS_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_BONUS_IMPORT>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_IMPORT>()
                .Property(e => e.POOL_BONUS_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_IMPORT>()
                .Property(e => e.PROJECT_BONUS_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_IMPORT>()
                .Property(e => e.RE_EMPLOYEE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_BONUS_IMPORT>()
                .Property(e => e.RE_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_IMPORT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_IMPORT>()
                .Property(e => e.IS_CHECK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BONUS_IMPORT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_BUSINESS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BUSINESS>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BUSINESS>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BUSINESS>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BUSINESS>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BUSINESS>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BUSINESS>()
                .Property(e => e.BUSINESS_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BUSINESS>()
                .Property(e => e.TAX_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BUSINESS>()
                .Property(e => e.CONTRACT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BUSINESS>()
                .Property(e => e.CONTRACT_AMOUNT_NO_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BUSINESS>()
                .Property(e => e.PURCHASE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BUSINESS>()
                .Property(e => e.PURCHASE_AMOUNT_NO_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BUSINESS>()
                .Property(e => e.SUPPLIER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_BUSINESS>()
                .Property(e => e.TYPE_PROFIT_PERCENTAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BUSINESS>()
                .Property(e => e.PROJECT_PERCENTAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BUSINESS>()
                .Property(e => e.PROJECT_ACTUAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_BUSINESS>()
                .Property(e => e.PROJECT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_CONTRACT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_CONTRACT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_CONTRACT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_CONTRACT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_CONTRACT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_CONTRACT>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_CONTRACT>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_STRUCT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_STRUCT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_STRUCT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_STRUCT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_STRUCT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_STRUCT>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_STRUCT>()
                .Property(e => e.CLASS_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_STRUCT>()
                .Property(e => e.COST_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_STRUCT>()
                .Property(e => e.AMOUNT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_STRUCT>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.FROM_PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.TO_PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.FROM_PROJECT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.TO_PROJECT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.FROM_PROJECT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.FROM_PROJECT_MANAGER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.TO_PROJECT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.TO_PROJECT_MANAGER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.TRANSFER_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.APPLY_EMPLOYYE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.APPLY_EMPLOYYE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.FROM_POOL_IN_OUT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.TO_POOL_IN_OUT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_COST_TRANSFER>()
                .Property(e => e.REIMBURSABLE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_DEPLOY_INFO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_DEPLOY_INFO>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_DEPLOY_INFO>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_DEPLOY_INFO>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_DEPLOY_INFO>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_DEPLOY_INFO>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_DEPLOY_INFO>()
                .Property(e => e.PROJECT_DEPLOY_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_DEPLOY_INFO>()
                .Property(e => e.DEPLOY_TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_DEPLOY_INFO>()
                .Property(e => e.DEPLOY_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_DEPLOY_INFO>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_DEPLOY_TYPE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_DEPLOY_TYPE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_DEPLOY_TYPE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_DEPLOY_TYPE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_DEPLOY_TYPE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_DEPLOY_TYPE>()
                .Property(e => e.PARENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_DEPLOY_TYPE>()
                .Property(e => e.DEPLOY_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_DEPLOY_TYPE>()
                .Property(e => e.DEPLOY_TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_DEPLOY_TYPE>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_FUNDS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_FUNDS>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_FUNDS>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_FUNDS>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_FUNDS>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_FUNDS>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_FUNDS>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_FUNDS>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_FUNDS>()
                .Property(e => e.PROJECT_FUNDS_POOL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_FUNDS>()
                .Property(e => e.PRODUCT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_FUNDS>()
                .Property(e => e.PERCENTAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_FUNDS>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MANAGER_CHANGE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MANAGER_CHANGE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MANAGER_CHANGE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MANAGER_CHANGE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MANAGER_CHANGE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MANAGER_CHANGE>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MANAGER_CHANGE>()
                .Property(e => e.PROJECT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MANAGER_CHANGE>()
                .Property(e => e.CHANGE_PROJECT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MANAGER_CHANGE>()
                .Property(e => e.MANAGER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_MANAGER_CHANGE>()
                .Property(e => e.CHANGER_MANAGER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_MANAGER_CHANGE>()
                .Property(e => e.APPLY_EMPLOYEE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_MANAGER_CHANGE>()
                .Property(e => e.PROJECT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_MANAGER_CHANGE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MANAGER_CHANGE>()
                .Property(e => e.PROJECT_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MANAGER_CHANGE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_MANAGER_CHANGE>()
                .Property(e => e.SPEND_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MANAGER_CHANGE>()
                .Property(e => e.APPLY_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MANAGER_CHANGE>()
                .Property(e => e.REIMBURSABLE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.RELEASE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.ACTUAL_RELEASE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.PROJECT_REIMBURSABLE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.PASS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.ADJUST_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.LINK_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.ATTACH_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.ADJUST_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.OVERAGE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE>()
                .Property(e => e.SALES_CONTRACT_MILESTONE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE_PRODUCT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE_PRODUCT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE_PRODUCT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE_PRODUCT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE_PRODUCT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE_PRODUCT>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE_PRODUCT>()
                .Property(e => e.PROJECT_MILESTONE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_MILESTONE_PRODUCT>()
                .Property(e => e.SIGN_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE_PRODUCT>()
                .Property(e => e.PROJECT_MILESTONE_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE_PRODUCT>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_MILESTONE_PRODUCT>()
                .Property(e => e.PERCENT)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_MILESTONE_PRODUCT>()
                .Property(e => e.SIGN_PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_MILESTONE_PRODUCT>()
                .Property(e => e.SIGN_PRODUCT_AMOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_MILESTONE_PRODUCT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_PERCENTAGE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PERCENTAGE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PERCENTAGE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PERCENTAGE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PERCENTAGE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PERCENTAGE>()
                .Property(e => e.POOL_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PERCENTAGE>()
                .Property(e => e.SALES_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PERCENTAGE>()
                .Property(e => e.PRODUCT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PERCENTAGE>()
                .Property(e => e.PERCENTAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PERCENTAGE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_PRODUCT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PRODUCT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PRODUCT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PRODUCT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PRODUCT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PRODUCT>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PRODUCT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_PRODUCT>()
                .Property(e => e.SALES_CONTRACT_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PRODUCT>()
                .Property(e => e.ARRIVAL_QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PRODUCT>()
                .Property(e => e.TOTAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PRODUCT>()
                .Property(e => e.PERCENTAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PROGRESS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PROGRESS>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PROGRESS>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PROGRESS>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PROGRESS>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PROGRESS>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PROGRESS>()
                .Property(e => e.PRODUCT_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PROGRESS>()
                .Property(e => e.SALES_CONTRACT_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PROGRESS>()
                .Property(e => e.IMPLEMENT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PROGRESS>()
                .Property(e => e.IMPLEMENT_EMPLOYEE_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_PROGRESS>()
                .Property(e => e.IMPLEMENT_EMPLOYEE_NAMES)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_PROGRESS>()
                .Property(e => e.DEVELOP_EMPLOYEE_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_PROGRESS>()
                .Property(e => e.DEVELOP_EMPLOYEE_NAMES)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_PROGRESS>()
                .Property(e => e.MAINTAIN_EMPLOYE_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_PROGRESS>()
                .Property(e => e.MAINTAIN_EMPLOYE_NAMES)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_PROGRESS>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_PROGRESS_TASK>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PROGRESS_TASK>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PROGRESS_TASK>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PROGRESS_TASK>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PROGRESS_TASK>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PROGRESS_TASK>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PROGRESS_TASK>()
                .Property(e => e.PROJECT_PROGRESS_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PROGRESS_TASK>()
                .Property(e => e.PROGRESS_TASK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_PROGRESS_TASK>()
                .Property(e => e.PROGRESS_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_PROGRESS_TASK>()
                .Property(e => e.INCOMPLETE_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_PROGRESS_TASK>()
                .Property(e => e.PROGRESS_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_PROGRESS_TASK>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_RELEASE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_RELEASE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_RELEASE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_RELEASE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_RELEASE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_RELEASE>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_RELEASE>()
                .Property(e => e.CONTRACT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_RELEASE>()
                .Property(e => e.PERCENTAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_RELEASE>()
                .Property(e => e.PROJECT_ACTUAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_RELEASE>()
                .Property(e => e.LIMIT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_RELEASE>()
                .Property(e => e.RELEASE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_RELEASE>()
                .Property(e => e.ACTUAL_RELEASE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_RELEASE>()
                .Property(e => e.RECEIVE_PAYMENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_RELEASE>()
                .Property(e => e.TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_RELEASE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_RELEASE>()
                .Property(e => e.PROJECT_REIMBURSABLE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_RELEASE>()
                .Property(e => e.ADJUST_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_SPEND>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_SPEND>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_SPEND>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_SPEND>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_SPEND>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_SPEND>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_SPEND>()
                .Property(e => e.EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_SPEND>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_SPEND>()
                .Property(e => e.SPEND_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_SPEND>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PR_PROJECT_SPEND>()
                .Property(e => e.DEPARTMENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_SPEND>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_PROJECT_SPEND>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RELATIONSHIP>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<RELATIONSHIP>()
                .Property(e => e.KEY)
                .IsUnicode(false);

            modelBuilder.Entity<RELATIONSHIP>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RELATIONSHIP>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RELATIONSHIP>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RELATIONSHIP>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RELATIONSHIP>()
                .Property(e => e.FIRSTID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RELATIONSHIP>()
                .Property(e => e.SECONDID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RELATIONSHIP>()
                .Property(e => e.THIRDID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RELATIONSHIP>()
                .Property(e => e.EXTENDINFO)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_APP_POWER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_APP_POWER>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_APP_POWER>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_APP_POWER>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_APP_POWER>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_APP_POWER>()
                .Property(e => e.PARENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_APP_POWER>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_APP_POWER>()
                .Property(e => e.POWER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_APP_POWER>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_APP_POWER>()
                .Property(e => e.TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_APP_POWER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_BUSINESS_NOTICE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_BUSINESS_NOTICE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_BUSINESS_NOTICE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_BUSINESS_NOTICE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_BUSINESS_NOTICE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_BUSINESS_NOTICE>()
                .Property(e => e.EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_BUSINESS_NOTICE>()
                .Property(e => e.NOTICE_TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_BUSINESS_NOTICE>()
                .Property(e => e.NOTICE_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_BUSINESS_NOTICE>()
                .Property(e => e.NOTICE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_BUSINESS_NOTICE>()
                .Property(e => e.LINK_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_BUSINESS_NOTICE>()
                .Property(e => e.READ_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_BUSINESS_NOTICE>()
                .Property(e => e.NOTICE_TASK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_BUSINESS_NOTICE>()
                .Property(e => e.FINISH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_BUSINESS_NOTICE>()
                .Property(e => e.SOURCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_BUSINESS_NOTICE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_COMPANY>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY>()
                .Property(e => e.COMPANY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_COMPANY>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_COMPANY>()
                .Property(e => e.PARENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY>()
                .Property(e => e.SHORT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_COMPANY>()
                .Property(e => e.ID_PATH)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_COMPANY>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.AUTO_COMPLETE_PROJECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.PROJECT_RELEASE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.PROJECT_AMOUNT_LIMIT_PERCENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.PROJECT_BUSINESS_PERCENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.HAND_COMPLETE_PROJECT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.CONTRACT_PAYMENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.PR_TECHNOLOGY_LIMIT_PERCENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.PR_BUSINESS_LIMIT_PERCENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.OUT_PRO_TECH_LIMIT_PERCENT)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.IN_PRO_TECH_LIMIT_PERCENT)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.IN_CITY_TECH_LIMIT_PERCENT)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.PURCHASE_INVOICE_APPROVAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.PR_BUSINESS_TEAM_WORK_PERCENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG>()
                .Property(e => e.NO_CONTRACT_INVOICE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG_PROJECT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG_PROJECT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG_PROJECT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG_PROJECT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG_PROJECT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG_PROJECT>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG_PROJECT>()
                .Property(e => e.KEY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG_PROJECT>()
                .Property(e => e.VALUE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG_PROJECT>()
                .Property(e => e.PERCENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_COMPANY_CONFIG_PROJECT>()
                .Property(e => e.SORT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_CUSTOM_ID>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_CUSTOM_ID>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_CUSTOM_ID>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_CUSTOM_ID>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_CUSTOM_ID>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_CUSTOM_ID>()
                .Property(e => e.TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_CUSTOM_ID>()
                .Property(e => e.CUSTOM_ID_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_CUSTOM_ID>()
                .Property(e => e.CUSTOM_ID_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_CUSTOM_ID>()
                .Property(e => e.CURRENT_NUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_CUSTOM_ID>()
                .Property(e => e.STEP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_CUSTOM_ID>()
                .Property(e => e.TOTAL_LENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_CUSTOM_ID>()
                .Property(e => e.MAX_VALUE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_CUSTOM_ID>()
                .Property(e => e.PREV_STR)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_CUSTOM_ID>()
                .Property(e => e.PREV_DATE_FORMAT)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_DATA_POWER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_DATA_POWER>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_DATA_POWER>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_DATA_POWER>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_DATA_POWER>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_DATA_POWER>()
                .Property(e => e.PARENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_DATA_POWER>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_DATA_POWER>()
                .Property(e => e.POWER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_DATA_POWER>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_DATA_POWER>()
                .Property(e => e.TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_DATA_POWER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_DEPARTMENT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_DEPARTMENT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_DEPARTMENT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_DEPARTMENT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_DEPARTMENT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_DEPARTMENT>()
                .Property(e => e.PARENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_DEPARTMENT>()
                .Property(e => e.DEPARTMENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_DEPARTMENT>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_DEPARTMENT>()
                .Property(e => e.ID_PATH)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_DEPARTMENT>()
                .Property(e => e.DEPARTMENT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_DEPARTMENT>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_DEPARTMENT>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_DEPARTMENT>()
                .Property(e => e.DEPTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_DEPARTMENT>()
                .Property(e => e.SUPDEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_DEPARTMENT>()
                .Property(e => e.SUPDEPTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_EMPLOYEE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE>()
                .Property(e => e.ACCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_EMPLOYEE>()
                .Property(e => e.PWD)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_EMPLOYEE>()
                .Property(e => e.EMPLOYEE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_EMPLOYEE>()
                .Property(e => e.PINYIN)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_EMPLOYEE>()
                .Property(e => e.SEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_EMPLOYEE>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_EMPLOYEE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_EMPLOYEE>()
                .Property(e => e.EMAIL_PWD)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_EMPLOYEE>()
                .Property(e => e.ICNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_EMPLOYEE_CONFIG>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_CONFIG>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_CONFIG>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_CONFIG>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_CONFIG>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_CONFIG>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_CONFIG>()
                .Property(e => e.INNER_TRADE_FINANCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_CONFIG>()
                .Property(e => e.INNER_TRADE_FINANCE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_EMPLOYEE_CONFIG>()
                .Property(e => e.PROJECT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_CONFIG>()
                .Property(e => e.PROJECT_MANAGER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_EMPLOYEE_DEPARTMENT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_DEPARTMENT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_DEPARTMENT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_DEPARTMENT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_DEPARTMENT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_DEPARTMENT>()
                .Property(e => e.EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_DEPARTMENT>()
                .Property(e => e.DEPARTMENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_DEPARTMENT>()
                .Property(e => e.POSITION_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_DEPARTMENT>()
                .Property(e => e.IS_MAIN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_DEPARTMENT>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_ROLE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_ROLE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_ROLE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_ROLE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_ROLE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_ROLE>()
                .Property(e => e.EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_ROLE>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_ROLE>()
                .Property(e => e.ROLE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_EMPLOYEE_ROLE>()
                .Property(e => e.COMPANY_ID_STR)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_EMPLOYEE_ROLE>()
                .Property(e => e.CUSTOM_MENU_POWER_STR)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_EMPLOYEE_ROLE>()
                .Property(e => e.CUSTOM_DATA_POWER_STR)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_EMPLOYEE_ROLE>()
                .Property(e => e.CUSTOM_APP_POWER_STR)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_EMPLOYEE_ROLE>()
                .Property(e => e.ROLE_ID_STR)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU_POWER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MENU_POWER>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MENU_POWER>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MENU_POWER>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MENU_POWER>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MENU_POWER>()
                .Property(e => e.PARENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MENU_POWER>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU_POWER>()
                .Property(e => e.PATH)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU_POWER>()
                .Property(e => e.POWER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU_POWER>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MENU_POWER>()
                .Property(e => e.TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MENU_POWER>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MENU_POWER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MILESTONE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MILESTONE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MILESTONE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MILESTONE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MILESTONE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MILESTONE>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MILESTONE>()
                .Property(e => e.SORT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MILESTONE>()
                .Property(e => e.SECTION_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MILESTONE>()
                .Property(e => e.COST_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MILESTONE>()
                .Property(e => e.PERCENT)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MILESTONE>()
                .Property(e => e.COST_RANGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MILESTONE>()
                .Property(e => e.BELONG_MODULE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MILESTONE>()
                .Property(e => e.MUST)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MILESTONE>()
                .Property(e => e.KEY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MILESTONE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_NOTICE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_NOTICE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_NOTICE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_NOTICE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_NOTICE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_NOTICE>()
                .Property(e => e.EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_NOTICE>()
                .Property(e => e.DEPARTMENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_NOTICE>()
                .Property(e => e.NOTICE_TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_NOTICE>()
                .Property(e => e.NOTICE_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OPERATION_LOG>()
                .Property(e => e.CONTROLLER)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OPERATION_LOG>()
                .Property(e => e.ACTION)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OPERATION_LOG>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_OPERATION_LOG>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_OPERATION_LOG>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_OPERATION_LOG>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OPERATION_LOG>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OPERATION_LOG>()
                .Property(e => e.RESULT)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OPERATION_LOG>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_OPERATION_LOG>()
                .Property(e => e.SYSTEMID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_PARAMETER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_PARAMETER>()
                .Property(e => e.PRM_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_PARAMETER>()
                .Property(e => e.PRM_VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_PARAMETER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_PARAMETER_ENUM>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_PARAMETER_ENUM>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_PARAMETER_ENUM>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_PARAMETER_ENUM>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_PARAMETER_ENUM>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_PARAMETER_ENUM>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_PARAMETER_ENUM>()
                .Property(e => e.KEY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_PARAMETER_ENUM>()
                .Property(e => e.VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_PARAMETER_ENUM>()
                .Property(e => e.ENUM_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_PARAMETER_ENUM>()
                .Property(e => e.SORT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_PARAMETER_ENUM>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_POSITION>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_POSITION>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_POSITION>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_POSITION>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_POSITION>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_POSITION>()
                .Property(e => e.POSITION_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_POSITION>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_POSITION>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_POSITION>()
                .Property(e => e.POSTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_POSITION>()
                .Property(e => e.NCID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.ROLE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.MENU_POWER_STR)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.DATA_POWER_STR)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.APP_POWER_STR)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_ROLE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SERIAL_NUMBER>()
                .Property(e => e.AREACODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_SERIAL_NUMBER>()
                .Property(e => e.YEAR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_SERIAL_NUMBER>()
                .Property(e => e.CURRENT_NUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_SERIAL_NUMBER>()
                .Property(e => e.BEGIN_NUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_SERIAL_NUMBER>()
                .Property(e => e.END_NUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_SERIAL_NUMBER>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_VERSION>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_VERSION>()
                .Property(e => e.VERSION)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_VERSION>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST>()
                .Property(e => e.RECEIVER)
                .IsUnicode(false);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST>()
                .Property(e => e.TELPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST>()
                .Property(e => e.ADDRESS_PROVINCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST>()
                .Property(e => e.ADDRESS_CITY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST>()
                .Property(e => e.ADDRESS_DISTRICT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST>()
                .Property(e => e.REQUEST_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST>()
                .Property(e => e.DELIVERY_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST_ITEM>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST_ITEM>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST_ITEM>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST_ITEM>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST_ITEM>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST_ITEM>()
                .Property(e => e.CONSUMABLE_REQUEST_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST_ITEM>()
                .Property(e => e.PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST_ITEM>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST_ITEM>()
                .Property(e => e.EXPRESS_NO)
                .IsUnicode(false);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST_ITEM>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_CONSUMABLE_REQUEST_ITEM>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.CUSTOMER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.RECEIVER)
                .IsUnicode(false);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.TELPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.ADDRESS_PROVINCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.ADDRESS_CITY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.ADDRESS_DISTRICT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.REQUEST_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.DELIVERY_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.SALES_DELIVERY_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY>()
                .Property(e => e.STOCK_IO_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_FEE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_FEE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_FEE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_FEE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_FEE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_FEE>()
                .Property(e => e.SALES_DELIVERY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_FEE>()
                .Property(e => e.DELIVERY_FEE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_FEE>()
                .Property(e => e.EXPRESS_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_FEE>()
                .Property(e => e.EXPRESS_NO)
                .IsUnicode(false);

            modelBuilder.Entity<TS_SALES_DELIVERY_FEE>()
                .Property(e => e.DELIVERY_FEE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_FEE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_FEE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<TS_SALES_DELIVERY_ITEM>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_ITEM>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_ITEM>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_ITEM>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_ITEM>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_ITEM>()
                .Property(e => e.SALES_DELIVERY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_ITEM>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_ITEM>()
                .Property(e => e.SALES_CONTRACT_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_ITEM>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_ITEM>()
                .Property(e => e.EXPRESS_NO)
                .IsUnicode(false);

            modelBuilder.Entity<TS_SALES_DELIVERY_ITEM>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_ITEM>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<TS_SALES_DELIVERY_ITEM>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TS_SALES_DELIVERY_ITEM>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE>()
                .Property(e => e.FLOW_MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE>()
                .Property(e => e.FLOW_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE>()
                .Property(e => e.FLOW_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE>()
                .Property(e => e.CREATE_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE>()
                .Property(e => e.CUSTOM_FORM)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE>()
                .Property(e => e.LINK_ID)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE>()
                .Property(e => e.FLOW_FUNC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE>()
                .Property(e => e.ATTACH_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE>()
                .Property(e => e.FLOW_NO)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_ATTACH>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_ATTACH>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_ATTACH>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_ATTACH>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_ATTACH>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_ATTACH>()
                .Property(e => e.UPLOAD_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_ATTACH>()
                .Property(e => e.FILENAME)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_ATTACH>()
                .Property(e => e.FILE_EXT)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_ATTACH>()
                .Property(e => e.FILE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_ATTACH>()
                .Property(e => e.FILE_SIZE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_ATTACH>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP>()
                .Property(e => e.FLOW_EXECUTE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP>()
                .Property(e => e.FLOW_EKP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP>()
                .Property(e => e.FLOW_EKP_MODEL_ID)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP_EMPLOYEE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP_EMPLOYEE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP_EMPLOYEE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP_EMPLOYEE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP_EMPLOYEE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP_EMPLOYEE>()
                .Property(e => e.FLOW_EXECUTE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP_EMPLOYEE>()
                .Property(e => e.FLOW_EXECUTE_EKP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP_EMPLOYEE>()
                .Property(e => e.EMPLOYEE_ID1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP_EMPLOYEE>()
                .Property(e => e.EMPLOYEE_ID2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP_EMPLOYEE>()
                .Property(e => e.EMPLOYEE_ID3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP_EMPLOYEE>()
                .Property(e => e.EMPLOYEE_ID4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP_EMPLOYEE>()
                .Property(e => e.EMPLOYEE_NAME1)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP_EMPLOYEE>()
                .Property(e => e.EMPLOYEE_NAME2)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP_EMPLOYEE>()
                .Property(e => e.EMPLOYEE_NAME3)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EKP_EMPLOYEE>()
                .Property(e => e.EMPLOYEE_NAME4)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.FLOW_EXECUTE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.ADDNODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.EMPLOYEE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.DEPARTMENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.DEPARTMENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.POSITION_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.POSITION_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.STEP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.FLOW_MODEL_NODE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.POSITION_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.NODE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.NODE_OPTION)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.INFLOW_CONDITION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.FLOW_NODE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.LOGICAL_OPERATION)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.RESULT_OPERATION)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.INFLOW_OPERATOR)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.INFLOW_VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.MENU_POWER_STR)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.DATA_POWER_STR)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.ADDTRANSFER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.SEND)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_EMPLOYEE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.FLOW_EXECUTE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.FLOW_MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.FLOW_MODEL_NODE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.STEP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.NODE_OPTION)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.CUSTOM_FORM)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.OPINION)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.SEND_EMAIL_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.READ_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.ATTACH_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.PARENT_EXECUTE_NODE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.FLOW_NODE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.LOGICAL_OPERATION)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.NODE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.PREV_NODE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.DEPARTMENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.POSITION_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.RESULT_OPERATION)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.MENU_POWER_STR)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.DATA_POWER_STR)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.SEND)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.POSITION_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE_EKP>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE_EKP>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE_EKP>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE_EKP>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE_EKP>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE_EKP>()
                .Property(e => e.FLOW_EXECUTE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE_EKP>()
                .Property(e => e.FLOW_EKP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE_EKP>()
                .Property(e => e.FD_NODE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE_EKP>()
                .Property(e => e.FD_NODE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE_EKP>()
                .Property(e => e.FD_ACTION_INFO)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE_EKP>()
                .Property(e => e.FD_ACTION_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE_EKP>()
                .Property(e => e.FD_AUDIT_NOTE)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_EXECUTE_NODE_EKP>()
                .Property(e => e.FD_HANDLER)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_MODEL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL>()
                .Property(e => e.FLOW_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL>()
                .Property(e => e.MODEL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_MODEL>()
                .Property(e => e.CUSTOM_FORM)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_MODEL>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_MODEL>()
                .Property(e => e.FLOW_FUNC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_EKP>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_EKP>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_EKP>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_EKP>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_EKP>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_EKP>()
                .Property(e => e.FLOW_FUNC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_EKP>()
                .Property(e => e.FLOW_EKP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_MODEL_EKP>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.FLOW_MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.PARENT_NODE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.FLOW_NODE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.LOGICAL_OPERATION)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.NODE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.DEPARTMENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.POSITION_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.EMPLOYEE_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.STEP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.NODE_OPTION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.CUSTOM_FORM)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.RESULT_OPERATION)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.POSITION_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.INFLOW_CONDITION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.INFLOW_OPERATOR)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.INFLOW_VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.MENU_POWER_STR)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.DATA_POWER_STR)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.SEND)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WF_FLOW_MODEL_NODE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WH_WORKHOURS_DETAILS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WH_WORKHOURS_DETAILS>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WH_WORKHOURS_DETAILS>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WH_WORKHOURS_DETAILS>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WH_WORKHOURS_DETAILS>()
                .Property(e => e.USERID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WH_WORKHOURS_DETAILS>()
                .Property(e => e.MAIN_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WH_WORKHOURS_DETAILS>()
                .Property(e => e.PROJECT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<WH_WORKHOURS_DETAILS>()
                .Property(e => e.PROJECT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WH_WORKHOURS_DETAILS>()
                .Property(e => e.FLOW_ID)
                .IsUnicode(false);

            modelBuilder.Entity<WH_WORKHOURS_DETAILS>()
                .Property(e => e.PROJECT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WH_WORKHOURS_DETAILS>()
                .Property(e => e.PROJECT_MANAGER_ICNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WH_WORKHOURS_DETAILS>()
                .Property(e => e.FROM_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WH_WORKHOURS_MAIN>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WH_WORKHOURS_MAIN>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WH_WORKHOURS_MAIN>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WH_WORKHOURS_MAIN>()
                .Property(e => e.REC_CREATOR_ICNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WH_WORKHOURS_MAIN>()
                .Property(e => e.TOTAL_HOUR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WH_WORKHOURS_MAIN>()
                .Property(e => e.FLOW_ID)
                .IsUnicode(false);

            modelBuilder.Entity<WH_WORKHOURS_MAIN>()
                .Property(e => e.CONTRACTID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WH_WORKHOURS_MAIN>()
                .Property(e => e.CATEGORY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WH_WORKHOURS_MAIN>()
                .Property(e => e.FROM_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK>()
                .Property(e => e.WAREHOUSE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK>()
                .Property(e => e.STOCK_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK>()
                .Property(e => e.MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK>()
                .Property(e => e.PRODUCT_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK>()
                .Property(e => e.PRODUCT_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK>()
                .Property(e => e.POSITION_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.WAREHOUSE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.STOCK_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.BATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.STOCK_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.BATCH_SERIAL_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.SALES_CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.PURCHASE_CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.SALES_CONTRACT_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.BATCH_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.PURCHASE_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.SALES_CONTRACT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.SIGN_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.IN_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_BATCH>()
                .Property(e => e.STOCK_IO_APPLY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.IO_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.WAREHOUSE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.CHECK_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.REQUEST_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.SOURCE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.SOURCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.SOURCE_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.STOCK_IO_NO)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.CHECK_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.EXPRESS_NO)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.EXPRESS_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.LINK_STOCK_IO_NO)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.TARGET_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.TARGET_WAREHOUSE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.TARGET_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.CUSTOMER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.PROJECT_INFO)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.SUPPLIER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.PROVINCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.CITY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.DISTRICT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.CONTACT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.IS_QC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.QC_RESULT)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.QC_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.WAREHOUSE_POSITION_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.TARGET_WAREHOUSE_POSITION_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.RECEIVE_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO>()
                .Property(e => e.LINK_STOCK_IO_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.STOCK_IO_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.STOCK_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.PRODUCT_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.PRODUCT_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.SOURCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.PRODUCT_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.PRODUCT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.PRODUCT_MODEL)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.SPECIFICATION)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.SUIT_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.PRODUCT_REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.IN_OUT_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.SN)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_APPLY>()
                .Property(e => e.MAINTENANCE_MONTH_REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.STOCK_IO_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.STOCK_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.STOCK_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.STOCK_BATCH_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.PRODUCT_TYPE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.PRODUCT_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.BATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.SOURCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.PRODUCT_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.PRODUCT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.PRODUCT_MODEL)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.SPECIFICATION)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.SUIT_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_BATCH>()
                .Property(e => e.PRODUCT_REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_ITEM>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_ITEM>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_ITEM>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_ITEM>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_ITEM>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_ITEM>()
                .Property(e => e.STOCK_IO_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_ITEM>()
                .Property(e => e.STOCK_IO_BATCH_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_ITEM>()
                .Property(e => e.STOCK_ITEM_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_ITEM>()
                .Property(e => e.SN)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_IO_ITEM>()
                .Property(e => e.STOCK_BATCH_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_ITEM>()
                .Property(e => e.STOCK_IO_APPLY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_IO_ITEM>()
                .Property(e => e.MAINTENANCE_MONTH_REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_ITEM>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_ITEM>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_ITEM>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_ITEM>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_ITEM>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_ITEM>()
                .Property(e => e.WAREHOUSE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_ITEM>()
                .Property(e => e.STOCK_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_ITEM>()
                .Property(e => e.STOCK_BATCH_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_ITEM>()
                .Property(e => e.STOCK_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_ITEM>()
                .Property(e => e.ITEM_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_STOCK_ITEM>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WM_STOCK_ITEM>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE>()
                .Property(e => e.WAREHOUSE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WM_WAREHOUSE>()
                .Property(e => e.ADDRESS_PROVINCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE>()
                .Property(e => e.ADDRESS_CITY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE>()
                .Property(e => e.ADDRESS_DISTRICT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<WM_WAREHOUSE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE>()
                .Property(e => e.QUALITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WM_WAREHOUSE>()
                .Property(e => e.WAREHOUSE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WM_WAREHOUSE>()
                .Property(e => e.LINK_SUPPLIER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE>()
                .Property(e => e.WAREHOUSE_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE_POSITION>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE_POSITION>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE_POSITION>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE_POSITION>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE_POSITION>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE_POSITION>()
                .Property(e => e.WAREHOUSE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE_POSITION>()
                .Property(e => e.POSITION_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WM_WAREHOUSE_POSITION>()
                .Property(e => e.POSITION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WM_WAREHOUSE_POSITION>()
                .Property(e => e.ADDRESS_PROVINCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE_POSITION>()
                .Property(e => e.ADDRESS_CITY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE_POSITION>()
                .Property(e => e.ADDRESS_DISTRICT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE_POSITION>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<WM_WAREHOUSE_POSITION>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE_POSITION>()
                .Property(e => e.LINK_SUPPLIER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE_POWER>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE_POWER>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE_POWER>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE_POWER>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE_POWER>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE_POWER>()
                .Property(e => e.WAREHOUSE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE_POWER>()
                .Property(e => e.POWER_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WM_WAREHOUSE_POWER>()
                .Property(e => e.TARGET_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_COMMON_SELECT_ITEM>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_COMMON_SELECT_ITEM>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_COMMON_SELECT_ITEM>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_COMMON_SELECT_ITEM>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_COMMON_SELECT_ITEM>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_COMMON_SELECT_ITEM>()
                .Property(e => e.ITEM_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_COMMON_SELECT_ITEM>()
                .Property(e => e.ITEM_VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMMON_SELECT_ITEM>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BASE_COMMON_SELECT_ITEM>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BIZ_REC_WATER>()
                .Property(e => e.TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIZ_REC_WATER>()
                .Property(e => e.ISURGENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIZ_REC_WATER>()
                .Property(e => e.OURAMOUNT)
                .HasPrecision(15, 4);

            modelBuilder.Entity<BIZ_REC_WATER>()
                .Property(e => e.ISPAYFAILSENDMSG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIZ_REC_WATER>()
                .Property(e => e.OPPPRIVATEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIZ_REC_WATER>()
                .Property(e => e.CONTRACTAMOUNT)
                .HasPrecision(15, 4);

            modelBuilder.Entity<BIZ_REC_WATER>()
                .Property(e => e.CONTRACTRECIVE)
                .HasPrecision(15, 4);

            modelBuilder.Entity<BIZ_REC_WATER>()
                .Property(e => e.ISMODIFY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIZ_REC_WATER>()
                .Property(e => e.DIVIDEDTAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIZ_REC_WATER>()
                .Property(e => e.ASSIGNED_COMPANYID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIZ_REC_WATER_DETAILS>()
                .Property(e => e.CONTRACTID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIZ_REC_WATER_DETAILS>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIZ_REC_WATER_DETAILS>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIZ_REC_WATER_DETAILS>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIZ_REC_WATER_DETAILS>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.BID_WIN_NO)
                .IsUnicode(false);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.PROJECT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.BID_WIN_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.PRIMA_COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.CREATE_COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.BID_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.BUSSINESSID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.BUSSINESSER)
                .IsUnicode(false);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.SIGN_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.CITY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.CITY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.PROVINCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.PROVINCE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.BUSINESS_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.BUSINESS_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.BID_ENTER_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.ENTER_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.APPLICANTNO)
                .IsUnicode(false);

            modelBuilder.Entity<BM_BID_WIN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.CONTRACT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.CONTRACT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.BUSINESS_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.PROJECT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.SALES_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.TEAMWORK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.PROVINCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.CITY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.DISTRICT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.EXCLUDINGTAX_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.INNER_EXCLUDINGTAX_PURCHASE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.OUTER_EXCLUDINGTAX_PURCHASE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.PROJECT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.SALE_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.BUSINESS_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.TECH_PROJECT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.BUSINESS_PROJECT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT>()
                .Property(e => e.PERIODTIME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_DETAILS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_DETAILS>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_DETAILS>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_DETAILS>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_DETAILS>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_DETAILS>()
                .Property(e => e.CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_DETAILS>()
                .Property(e => e.CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_DETAILS>()
                .Property(e => e.CONTRACT_NO_BPM)
                .IsUnicode(false);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_DETAILS>()
                .Property(e => e.CONTRACT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_DETAILS>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_DETAILS>()
                .Property(e => e.CUSTOMER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_DETAILS>()
                .Property(e => e.TAX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_DETAILS>()
                .Property(e => e.AMOUNT_NOTAX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_DETAILS>()
                .Property(e => e.AGGREGATE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_FINANCE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_FINANCE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_FINANCE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_FINANCE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_FINANCE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_FINANCE>()
                .Property(e => e.CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_FINANCE>()
                .Property(e => e.CONTRACT_NO_BPM)
                .IsUnicode(false);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_FINANCE>()
                .Property(e => e.CONTRACT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_FINANCE>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_FINANCE>()
                .Property(e => e.CUSTOMER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_FINANCE>()
                .Property(e => e.RECEIVE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_FINANCE>()
                .Property(e => e.AGGREGATE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_FINANCE>()
                .Property(e => e.CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_INVOICE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_INVOICE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_INVOICE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_INVOICE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_INVOICE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_INVOICE>()
                .Property(e => e.CONTRACT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_INVOICE>()
                .Property(e => e.CUSTOMER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_INVOICE>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_INVOICE>()
                .Property(e => e.INVOICE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_INVOICE>()
                .Property(e => e.INVOICE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_INVOICE>()
                .Property(e => e.AGGREGATE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_INVOICE>()
                .Property(e => e.CONTRACT_NO_BPM)
                .IsUnicode(false);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_INVOICE>()
                .Property(e => e.INVOICE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_AGGREGATE_CONTRACT_INVOICE>()
                .Property(e => e.CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CM_FUNCTIONPOINT_DETAILS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_FUNCTIONPOINT_DETAILS>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_FUNCTIONPOINT_DETAILS>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_FUNCTIONPOINT_DETAILS>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_FUNCTIONPOINT_DETAILS>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_FUNCTIONPOINT_DETAILS>()
                .Property(e => e.SALE_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_FUNCTIONPOINT_DETAILS>()
                .Property(e => e.FUNCTIONPOINT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_FUNCTIONPOINT_DETAILS>()
                .Property(e => e.LINK_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_P_INFO_RELATION>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_P_INFO_RELATION>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_P_INFO_RELATION>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_P_INFO_RELATION>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_P_INFO_RELATION>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_P_INFO_RELATION>()
                .Property(e => e.FROM_INFO_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_P_INFO_RELATION>()
                .Property(e => e.TO_INFO_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SOFTCHANGE_EVALUATION>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SOFTCHANGE_EVALUATION>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SOFTCHANGE_EVALUATION>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SOFTCHANGE_EVALUATION>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SOFTCHANGE_EVALUATION>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SOFTCHANGE_EVALUATION>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CM_SOFTCHANGE_EVALUATION>()
                .Property(e => e.ESTIMATESVALUE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SOFTCHANGE_EVALUATION>()
                .Property(e => e.FUNCTIONPOINTS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SOFTCHANGE_EVALUATION>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SOFTCHANGE_EVALUATION>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SOFTCHANGE_EVALUATION>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_SOFTCHANGE_EVALUATION>()
                .Property(e => e.TO_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.SALE_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.US)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.CF)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.S)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.PDR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.UE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.QR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.XC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.AE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.HM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.F)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.P)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.SOFTCHANGE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT>()
                .Property(e => e.FROM_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.SALE_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.SON_SYSTEM)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.FIRST_MODULE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.POINT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.UFP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.REUSABILITY)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.CHANGE_POINT)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.US_INFO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.REMARK_INFO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.SOFTCHANGE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.POINT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.FROM_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.POINT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT_FUNCTIONPOINT_INFO>()
                .Property(e => e.ORDERNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CUSTOMER_BANK>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CUSTOMER_BANK>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CUSTOMER_BANK>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CUSTOMER_BANK>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CUSTOMER_BANK>()
                .Property(e => e.CUSTOMERID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CUSTOMER_BANK>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CRM_CUSTOMER_BANK>()
                .Property(e => e.ORDERNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_PARTS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_PARTS>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_PARTS>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_PARTS>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_PARTS>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_PARTS>()
                .Property(e => e.PARTS_MODEL_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_PARTS>()
                .Property(e => e.PARTS_SN)
                .IsUnicode(false);

            modelBuilder.Entity<DM_PARTS>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_PARTS>()
                .Property(e => e.QUALITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_PARTS>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<DM_PARTS>()
                .Property(e => e.DEVICE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DM_PARTS>()
                .Property(e => e.SOURCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HR_DEPT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HR_DEPT>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HR_DEPT>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HR_DEPT>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HR_DEPT>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HR_DEPT>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<HR_DEPT>()
                .Property(e => e.KEYWORD)
                .IsUnicode(false);

            modelBuilder.Entity<HR_DEPT>()
                .Property(e => e.SORTORDER)
                .IsUnicode(false);

            modelBuilder.Entity<HR_DEPT>()
                .Property(e => e.NO)
                .IsUnicode(false);

            modelBuilder.Entity<HR_DEPT>()
                .Property(e => e.PARENT)
                .IsUnicode(false);

            modelBuilder.Entity<HR_DEPT>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<HR_DEPT>()
                .Property(e => e.THISLEADER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HR_DEPT>()
                .Property(e => e.SUPERLEADER)
                .IsUnicode(false);

            modelBuilder.Entity<HR_DEPT>()
                .Property(e => e.DATASTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<HR_DEPT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_CONTRACTINFO_CHANGE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_CONTRACTINFO_CHANGE>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_CONTRACTINFO_CHANGE>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_CONTRACTINFO_CHANGE>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_CONTRACTINFO_CHANGE>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_CONTRACTINFO_CHANGE>()
                .Property(e => e.PROJECT_MANAGER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_CONTRACTINFO_CHANGE>()
                .Property(e => e.SALES_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_CONTRACTINFO_CHANGE>()
                .Property(e => e.PROJECT_MANAGER_ID_NEW)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_CONTRACTINFO_CHANGE>()
                .Property(e => e.SALES_ID_NEW)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_CONTRACTINFO_CHANGE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_CONTRACTINFO_CHANGE>()
                .Property(e => e.CM_SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_CONTRACTINFO_CHANGE>()
                .Property(e => e.MAIN_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_CONTRACTINFO_CHANGE_MAIN>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_CONTRACTINFO_CHANGE_MAIN>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_CONTRACTINFO_CHANGE_MAIN>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_CONTRACTINFO_CHANGE_MAIN>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_CONTRACTINFO_CHANGE_MAIN>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOG_CONTRACTINFO_CHANGE_MAIN>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_CONTRACTINFO_CHANGE_MAIN>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_PROJECT_BILL>()
                .Property(e => e.OA_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_PROJECT_BILL>()
                .Property(e => e.PROJECT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT_BILL>()
                .Property(e => e.PROJECT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT_BILL>()
                .Property(e => e.EMPLOYEE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT_BILL>()
                .Property(e => e.EMPLOYEE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT_BILL>()
                .Property(e => e.SALES_CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT_BILL>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_PROJECT_BILL>()
                .Property(e => e.REAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_PROJECT_BILL>()
                .Property(e => e.PAY_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT_BILL>()
                .Property(e => e.ACCOUNT_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT_BILL>()
                .Property(e => e.BILL_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT_BILL>()
                .Property(e => e.AMOUNT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT_BILL>()
                .Property(e => e.IS_FUNDS_POOL)
                .IsUnicode(false);

            modelBuilder.Entity<OA_PROJECT_BILL>()
                .Property(e => e.IS_SYNC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_SALES_CUSTOMER>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CUSTOMER>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CUSTOMER>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CUSTOMER>()
                .Property(e => e.INDUSTRYID)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CUSTOMER>()
                .Property(e => e.COUNTRYID)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CUSTOMER>()
                .Property(e => e.OTHERMSG)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CUSTOMER>()
                .Property(e => e.UPDATEUSERNO)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CUSTOMER>()
                .Property(e => e.CREATETIME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CUSTOMER>()
                .Property(e => e.UPDATETIME)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CUSTOMER>()
                .Property(e => e.GLEVEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OA_SALES_CUSTOMER>()
                .Property(e => e.PCUSTOMERID)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CUSTOMER>()
                .Property(e => e.TEL)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CUSTOMER>()
                .Property(e => e.BANK)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CUSTOMER>()
                .Property(e => e.BANKACCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<OA_SALES_CUSTOMER>()
                .Property(e => e.TAXNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT_TAG>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TAG>()
                .Property(e => e.TAG_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TAG>()
                .Property(e => e.TAG_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT_TAG>()
                .Property(e => e.TAG_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PM_PRODUCT_TAG>()
                .Property(e => e.SORT_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TAG>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TAG>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TAG>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PM_PRODUCT_TAG>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.PURCHASE_APPLY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.SALES_CONTRACT_PRODUCT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.SPECIFIC_SUPPLIER)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.CUSTOMER_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.SPEC_PARAM)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.PURCHASE_QUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.MAINTENANCE_MONTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.MAINTENANCE_MONTH_REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.DEF1)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.DEF2)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.DEF3)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.DEF4)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.DEF5)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.DEF6)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.DEF7)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCAERDPURCHASE_APPLY_ITEM>()
                .Property(e => e.DEF8)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.APPLY_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.PURCHASE_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.ATTACH_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.PURCHASE_EMPLOYEE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.APPLY_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.PURCHASE_APPLY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.IS_SPECIFIC_SUPPLIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.SPECIFIC_SUPPLIER)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.ITEM_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.APPLY_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.DEPARTMENT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.SOURCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.RECEIVEINFO)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.CARDTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.BANKCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PO_ICCARDPURCHASE_APPLY>()
                .Property(e => e.BANKNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_IDCAREINFO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_IDCAREINFO>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_IDCAREINFO>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_IDCAREINFO>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_IDCAREINFO>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_IDCAREINFO>()
                .Property(e => e.MAIN_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PO_PURCHASE_APPLY_IDCAREINFO>()
                .Property(e => e.DEF1)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_IDCAREINFO>()
                .Property(e => e.DEF2)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_IDCAREINFO>()
                .Property(e => e.DEF3)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_IDCAREINFO>()
                .Property(e => e.DEF4)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_IDCAREINFO>()
                .Property(e => e.DEF5)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_IDCAREINFO>()
                .Property(e => e.DEF6)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_IDCAREINFO>()
                .Property(e => e.DEF7)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_IDCAREINFO>()
                .Property(e => e.DEF8)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_IDCAREINFO>()
                .Property(e => e.DEF9)
                .IsUnicode(false);

            modelBuilder.Entity<PO_PURCHASE_APPLY_IDCAREINFO>()
                .Property(e => e.DEF10)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SERVICES>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_SERVICES>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_SERVICES>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_SERVICES>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_SERVICES>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_SERVICES>()
                .Property(e => e.SERVICE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SERVICES>()
                .Property(e => e.RUN_HOUR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_SERVICES>()
                .Property(e => e.RUN_CYCLE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_SERVICES>()
                .Property(e => e.SERVICE_PARAMETER)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SERVICES>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_STATUS_LOG>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_STATUS_LOG>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_STATUS_LOG>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_STATUS_LOG>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_STATUS_LOG>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_STATUS_LOG>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_STATUS_LOG>()
                .Property(e => e.STATUS_NEW)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_STATUS_LOG>()
                .Property(e => e.LINK_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_STATUS_LOG>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_STATUS_LOG>()
                .Property(e => e.STATUS_REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BIZ_REC_WATER_VIEW>()
                .Property(e => e.TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIZ_REC_WATER_VIEW>()
                .Property(e => e.ISURGENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIZ_REC_WATER_VIEW>()
                .Property(e => e.OURAMOUNT)
                .HasPrecision(15, 4);

            modelBuilder.Entity<BIZ_REC_WATER_VIEW>()
                .Property(e => e.ISPAYFAILSENDMSG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIZ_REC_WATER_VIEW>()
                .Property(e => e.OPPPRIVATEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIZ_REC_WATER_VIEW>()
                .Property(e => e.CONTRACTAMOUNT)
                .HasPrecision(15, 4);

            modelBuilder.Entity<BIZ_REC_WATER_VIEW>()
                .Property(e => e.CONTRACTRECIVE)
                .HasPrecision(15, 4);

            modelBuilder.Entity<BIZ_REC_WATER_VIEW>()
                .Property(e => e.ISMODIFY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIZ_REC_WATER_VIEW>()
                .Property(e => e.ASSIGNED_COMPANYID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIZ_REC_WATER_VIEW>()
                .Property(e => e.ASSIGNED_COMPANY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BIZ_REC_WATER_VIEW>()
                .Property(e => e.TOTALDIVIDE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BIZ_REC_WATER_VIEW>()
                .Property(e => e.APPROVESTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.PURCHASE_OUT_ACTUAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.PURCHASE_IN_ACTUAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.BUSINESS_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.TECHNOLOGY_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.CONTRACTAMOUNT)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.PURCHASE_IN)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.PURCHASE_OUT)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.OCCUPANCY_COST)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.IMPLEMENTATION_LIMIT)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.IMPLEMENTATION)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.IMPLEMENTATIONM)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.DEVELOPMENT)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.DEVELOPMENTM)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.BUSINESS_LIMIT)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.BUSINESS)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.FREE_MAINTENANCE)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.BIDDING_SERVICE_FEE)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.OTHER_COSTS)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.PROFIT_TOTAL)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.PROFIT_RATE)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CM_PROJECT_PROFITS_VIEW>()
                .Property(e => e.CONTRACTAMOUNT_NOTAX)
                .HasPrecision(15, 4);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.CUSTOMER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.REC_DELETED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.REC_CREATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.REC_MODIFIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.REC_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.CONTRACT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.CONTRACT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.SALES_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.IS_ALL_ORDERED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.COMPLETION_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.CONTRACT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.SALES_MODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.PARENT_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.BELONG_YEAR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.SOURCE_SALES_CONTRACT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.SUBCONTRACT_SOURCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.IS_FORMAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.PROVINCE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.CITY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.DISTRICT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.DISCOUNT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.CONVERSION_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.BE_CONVERSION_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.EXPENSE_POOL_IDS)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.BUSINESS_TYPE2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.IS_INNERCONTRACT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.BELONG_PLATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.SALES_PLAN_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.CONTRACT_NO_BPM)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.CONTRACT_MECHANISM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.ISTENDER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.WINNINGBIDARCHIVE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.BUSINESS_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.FINISH_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.CONTRACT_NO_BPM2)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.IS_PUBLIC_PROJECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.CREATE_COMPANY_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACTRECEICEDAMOUNT_VIEW>()
                .Property(e => e.RECEIVE_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<NC_SDEPTMENT_COMPANY_RELATION>()
                .Property(e => e.DEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<NC_SDEPTMENT_COMPANY_RELATION>()
                .Property(e => e.DEPTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<NC_SDEPTMENT_COMPANY_RELATION>()
                .Property(e => e.CDEPT)
                .IsUnicode(false);

            modelBuilder.Entity<NC_SDEPTMENT_COMPANY_RELATION>()
                .Property(e => e.SUPDEPTID)
                .IsUnicode(false);

            modelBuilder.Entity<NC_SDEPTMENT_COMPANY_RELATION>()
                .Property(e => e.SUPDEPTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<NC_SDEPTMENT_COMPANY_RELATION>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<NC_SDEPTMENT_COMPANY_RELATION>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<NC_SDEPTMENT_COMPANY_RELATION>()
                .Property(e => e.DEPTKIND)
                .IsUnicode(false);

            modelBuilder.Entity<NC_SDEPTMENT_COMPANY_RELATION>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<NC_SDEPTMENT_COMPANY_RELATION>()
                .Property(e => e.COMPANY_ID)
                .HasPrecision(38, 0);
        }
    }
}

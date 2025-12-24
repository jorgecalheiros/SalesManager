CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

START TRANSACTION;
CREATE TABLE clients (
    id uuid NOT NULL,
    name character varying(200) NOT NULL,
    email character varying(254) NOT NULL,
    phone_number character varying(50) NOT NULL,
    created_at timestamp with time zone NOT NULL,
    updated_at timestamp with time zone NOT NULL,
    CONSTRAINT "PK_clients" PRIMARY KEY (id)
);

CREATE TABLE products (
    id uuid NOT NULL,
    name character varying(200) NOT NULL,
    description character varying(1000) NOT NULL,
    price numeric(18,2) NOT NULL,
    stock integer NOT NULL,
    created_at timestamp with time zone NOT NULL,
    updated_at timestamp with time zone NOT NULL,
    CONSTRAINT "PK_products" PRIMARY KEY (id)
);

CREATE TABLE sales (
    id uuid NOT NULL,
    client_id uuid NOT NULL,
    created_at timestamp with time zone NOT NULL,
    updated_at timestamp with time zone NOT NULL,
    CONSTRAINT "PK_sales" PRIMARY KEY (id)
);

CREATE TABLE sale_items (
    id uuid NOT NULL,
    product_id uuid NOT NULL,
    unit_price numeric(18,2) NOT NULL,
    quantity integer NOT NULL,
    sale_id uuid NOT NULL,
    "SaleId1" uuid,
    created_at timestamp with time zone NOT NULL,
    updated_at timestamp with time zone NOT NULL,
    CONSTRAINT "PK_sale_items" PRIMARY KEY (id),
    CONSTRAINT "FK_sale_items_products_product_id" FOREIGN KEY (product_id) REFERENCES products (id) ON DELETE RESTRICT,
    CONSTRAINT "FK_sale_items_sales_SaleId1" FOREIGN KEY ("SaleId1") REFERENCES sales (id),
    CONSTRAINT "FK_sale_items_sales_sale_id" FOREIGN KEY (sale_id) REFERENCES sales (id) ON DELETE CASCADE
);

CREATE INDEX "IX_sale_items_product_id" ON sale_items (product_id);

CREATE INDEX "IX_sale_items_sale_id" ON sale_items (sale_id);

CREATE INDEX "IX_sale_items_SaleId1" ON sale_items ("SaleId1");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20251223030245_Initial', '9.0.10');

COMMIT;


const env = process.env;

export const API_SECRET = env.API_SECRET ? env.API_SECRET : "fgnkdfjngod9489en923h889rhfrhnnert0493fdpofmertj954jg=";
export const DB_HOST = env.DB_HOST ? env.DB_HOST : "localhost";
export const DB_NAME = env.DB_NAME ? env.DB_NAME : "auth-db";
export const DB_USER = env.DB_USER ? env.DB_USER : "postgres";
export const DB_PASSWORD = env.DB_PASSWORD ? env.DB_PASSWORD : "senha";
export const DB_PORT = env.DB_PORT ? env.DB_PORT : "5432";
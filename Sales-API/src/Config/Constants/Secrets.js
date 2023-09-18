const env = process.env;

export const MONGO_DB_URL = env.MONGO_DB_URL ? env.MONGO_DB_URL : "mongodb://admin:123456@localhost:27017";
export const API_SECRET = env.API_SECRET ? env.API_SECRET : "fgnkdfjngod9489en923h889rhfrhnnert0493fdpofmertj954jg=";
export const RABBIT_MQ_URL = env.RABBIT_MQ_URL ? env.RABBIT_MQ_URL : "amqp://localhost:5672";
export const PRODUCT_API_URL = env.PRODUCT_API_URL ? env.PRODUCT_API_URL : "http://localhost:8081/api/product";
import express from "express";

import { connectMongoDb } from "./src/Config/Db/MongoDbConfig.js";
import { createInitialData } from "./src/Config/Db/InitialData.js";
import { connectRabbitMq } from "./src/Config/RabbitMQ/RabbitConfig.js";

import CheckToken from "./src/Config/Auth/CheckToken.js";
import OrderRoutes from "./src/Modules/Sales/Routes/OrderRouters.js";
import Tracing from "./src/Config/Tracing.js";

const app = express();
const env = process.env;
const PORT = env.PORT || 8082;
const CONTAINER_ENV = "container";
const THREE_MINUTES = 180000;


startApplication();

async function startApplication() {
  if (CONTAINER_ENV === env.NODE_ENV) {
    console.info("Waiting for RabbitMQ and MongoDB containers to start...");
    setInterval(() => {
      connectMongoDb();
      connectRabbitMq();
    }, THREE_MINUTES);
  } else {
    connectMongoDb();
    createInitialData();
    connectRabbitMq();
  }
}

app.use(express.json());

app.get("/", (req, res) => {
  return res.status(200).json(getOkResponse());
});

app.get("/api/status", (req, res) => {
  return res.status(200).json(getOkResponse());
});

function getOkResponse() {
  return {
    service: "Sales-API",
    status: "up",
    httpStatus: 200,
  }
}

app.use(Tracing);
app.use(CheckToken);
app.use(OrderRoutes);

app.listen(PORT, () => {
  console.info(`Server started successfully at port ${PORT}`);
});
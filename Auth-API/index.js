import express from "express";

import * as db from "./src/Config/db/initialData.js";
import userRoutes from "./src/Modules/user/Router/UserRoutes.js"
import CheckToken from "./src/Config/Auth/CheckToken.js"

const app = express();
const env = process.env;
const PORT = env.PORT || 8080;

db.createInitialData();

app.use(express.json());
app.use(userRoutes);

app.get('/api/status', (req, res) => {
    return res.status(200).json({
        service: "Auth-API",
        status: "up",
        httpStatus: 200
    })
})

app.listen(PORT, () => {
    console.log(`Server started successfullt at port ${PORT}`)
})
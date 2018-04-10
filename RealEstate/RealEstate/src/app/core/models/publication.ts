export class Publication
{
    constructor(
        public Id: number,
        public RentalObjectId: number,
        public FromDate: Date,
        public ToDate?: Date)
    {
    }
}
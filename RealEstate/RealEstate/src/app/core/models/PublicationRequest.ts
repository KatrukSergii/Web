
export class PublicationRequest
{
    constructor(public RequestDate : Date,
        public PublicationId: number,
        public FromDate?: Date,
        public DateTime?: Date,
        public ContactEmail?: string,
        public ContactPhone?: string)
    {
    }
}
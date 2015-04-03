﻿namespace TeamElderberryProject
{
    using TeamElderberryProject.Interfaces;

    public abstract class Income : Transaction, IIncome
    {
        protected Income(TransactionData data, string description, TransactionType transactionType)
            : base(data, description, TransactionType.Income)
        {

        }
    }
}
